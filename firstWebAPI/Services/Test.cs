using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace firstWebAPI.Services
{
    public class Test
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        public Test(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        private void SetupHttpContextAsync()
        {
                var jwt = "eyJhbGciOiJSUzI1NiIsImtpZCI6Ik1UWTJNVEk1T1RJd05BPT0iLCJ0eXAiOiJKV1QifQ.eyJ1bmlxdWVfbmFtZSI6InBrb3JhZGFAc2xiLmNvbSIsImRwaWQiOiJkcmlsbHBsYW4tc2hhcmVkLWRyaWxscGxhbi1zaGEiLCJjdGlkIjoiRHJpbGxQbGFuLVNoYXJlZCIsInR5cGUiOiJzZXJ2aWNldG9rZW4iLCJmdHIiOiJTdGFuZGFyZF9BY2Nlc3MiLCJuYW1laWQiOiJwa29yYWRhQHNsYi5jb20iLCJuYmYiOjE2NjEzNzE4MjYsImV4cCI6MTY2MTM3MzYyNiwiaWF0IjoxNjYxMzcxODI2LCJpc3MiOiJ0YWlqaS1zdHMtZGV2LmF6dXJld2Vic2l0ZXMubmV0IiwiYXVkIjoiTG9jYWxob3N0VG9rZW5DbGllbnQifQ.ZTJFOAhFYYtPKrj3jMnrL2hBpoVUKqZYYJdI88rwZkfVGt3ZLLA52uD4AO354FZOHCRf2ol1z1WmgaY33xj-TRH9hYfp9oyAocEnUtCkH3I2LG_0TkV6KTU8k2Vn8D9uFUVBkgTI_2xtPodRqPjsc4iKMsoif1TJSQLnwNMoBTKcx5RsvFFefFIjT7YSBafnaALTu35hD53XO_gNt49oI-k79I4DCcUqBc4yKGdt6y5RdQ4Wgb_DrbhOCYG5mWdZexGrCka4Yy5UiSFwmxEnNlNd15j0Qd_RLH7PkccdiGnDfrNAx75cOIjuYiO4DQVG-wRzqB8ELSwexdLny5RMPw";
                httpContextAccessor.HttpContext = new DefaultHttpContext();
                //var headers = new Dictionary<string, string> { ["Authorization"] = $"Bearer {jwt}" };
                httpContextAccessor.HttpContext.Request.Headers.TryAdd("Authorization", $"Bearer {jwt}");            
           
        }
    }
}
