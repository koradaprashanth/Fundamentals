using Newtonsoft.Json;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace firstWebAPI.Services
{
    public delegate void HttpRequestInterceptor(RestClientHttpRequestMessage request);
    public interface IRestClient
    {
        Task<HttpResponseMessage> GetAsync(string uri, RequestContext requestContext = null);
        Task<HttpResponseMessage> PutAsync(string uri, object content = null, RequestContext requestContext = null);
        Task<HttpResponseMessage> PostAsync(string uri, object content = null, RequestContext requestContext = null);
        Task<HttpResponseMessage> DeleteAsync(string uri, RequestContext requestContext = null);


        event HttpRequestInterceptor RequestReadyToSend;

    }
    public class RestHttpClient : IRestClient
    {
        private readonly ITokenService tokenService;
        private readonly HttpClient client;
        private readonly Uri baseAddress;
        private readonly int timeoutInSeconds;
        public event HttpRequestInterceptor RequestReadyToSend;

        public RestHttpClient(HttpClient client, ITokenService tokenService, string baseAddress, int timeoutInSeconds = 100)
        {
            this.tokenService = tokenService;
            this.client = client;
            this.baseAddress = new Uri(baseAddress.EndsWith("/") ? baseAddress : baseAddress + "/");
            this.timeoutInSeconds = timeoutInSeconds;
        }

        public async Task<HttpResponseMessage> GetAsync(string uri, RequestContext requestContext = null)
        {
            var requestMessage = await CreateRequestMessageAsync(uri, HttpMethod.Get);
            var response = await SendWithCustomTimeoutAsync(requestMessage, requestContext);
            return response;
        }

        public async Task<HttpResponseMessage> PutAsync(string uri, object content = null, RequestContext requestContext = null)
        {
            var requestMessage = await CreateRequestMessageAsync(uri, HttpMethod.Put, content);
            var response = await SendWithCustomTimeoutAsync(requestMessage, requestContext);
            return response;
        }

        public async Task<HttpResponseMessage> PostAsync(string uri, object content = null, RequestContext requestContext = null)
        {
            var requestMessage = await CreateRequestMessageAsync(uri, HttpMethod.Post, content);
            var response = await SendWithCustomTimeoutAsync(requestMessage, requestContext);
            return response;
        }

        public async Task<HttpResponseMessage> DeleteAsync(string uri, RequestContext requestContext = null)
        {
            var requestMessage = await CreateRequestMessageAsync(uri, HttpMethod.Delete);
            var response = await SendWithCustomTimeoutAsync(requestMessage, requestContext);
            return response;
        }

        private async Task<HttpRequestMessage> CreateRequestMessageAsync(string uri, HttpMethod method, object content = null)
        {
            uri = uri.StartsWith("/") ? uri.Remove(0, 1) : uri;
            var requestMessage = new HttpRequestMessage(method, new Uri(baseAddress, uri));

            string jsonContent = null;
            if (content != null)
            {
                jsonContent = JsonConvert.SerializeObject(content);
                requestMessage.Content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            }

            var token = await tokenService.GetTokenAsync();
            requestMessage.Headers.Add("Authorization", $"Bearer {token}");

            OnRequestReadyToSend(new RestClientHttpRequestMessage(requestMessage, jsonContent));

            return requestMessage;
        }

        private async Task<HttpResponseMessage> SendWithCustomTimeoutAsync(HttpRequestMessage requestMessage, RequestContext requestContext)
        {
            var cts = new CancellationTokenSource();
            var timeoutSec = requestContext?.RequestTimeoutSec ?? timeoutInSeconds;
            var requestContextWithTimeout = new RequestContext(requestContext?.ServiceTitle, requestContext?.RequestName, timeoutSec);
            cts.CancelAfter(TimeSpan.FromSeconds(timeoutSec));

            try
            {
                var response = await client.SendAsync(requestMessage, cts.Token);
                return response;
            }
            catch (IOException exception)
            {
                throw new RequestTimeoutException(requestContextWithTimeout, exception, requestMessage.RequestUri.ToString());
            }
            catch (TaskCanceledException exception)
            {
                throw new RequestTimeoutException(requestContextWithTimeout, exception, requestMessage.RequestUri.ToString());
            }
        }

        protected virtual void OnRequestReadyToSend(RestClientHttpRequestMessage request)
        {
            RequestReadyToSend?.Invoke(request);
        }
    }

    public class RequestContext
    {
        public RequestContext(string serviceTitle, string requestName = null, int? requestTimeoutSec = null)
        {
            ServiceTitle = serviceTitle;
            RequestName = requestName;
            RequestTimeoutSec = requestTimeoutSec;
        }

        public string ServiceTitle { get; }
        public string RequestName { get; }

        public int? RequestTimeoutSec { get; set; }
    }

    public class RestClientHttpRequestMessage
    {
        public RestClientHttpRequestMessage(HttpRequestMessage request, string deserializedBody)
        {
            HttpRequestMessage = request;
            DeserializedBody = deserializedBody;
        }

        public HttpRequestMessage HttpRequestMessage { get; set; }
        public string DeserializedBody { get; set; }
    }

    public class RequestTimeoutException : Exception
    {
        public RequestContext RequestContext { get; }

        public RequestTimeoutException(RequestContext requestContext, Exception innerException, string url)
            : base(
                  $"Request {requestContext?.RequestName} to service {requestContext?.ServiceTitle ?? string.Empty} failed by timeout ({requestContext?.RequestTimeoutSec} sec), url: {url}",
                  innerException)
        {
            RequestContext = requestContext;
        }
    }

}
