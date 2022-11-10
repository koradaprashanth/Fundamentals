using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BasicProblems.ExcelImport
{
    public class Technology : ITechnology
    {
        private const string TechnologyDataPath = @"BasicProblems.ExcelImport.technology.json";
        private readonly List<string> technologies;

        public Technology()
        {
            var technologyJson = JsonFromResourceProvider.GetJson(TechnologyDataPath);
            var data = JObject.Parse(technologyJson).SelectToken("Technology").ToString();
            technologies = JsonConvert.DeserializeObject<List<string>>(data);
        }

        public List<string> GetTechnologies()
        {
            return technologies;
        }
    }
}
