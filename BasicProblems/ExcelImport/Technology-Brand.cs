using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems.ExcelImport
{
    public class Technology_Brand :ITechnology_Brand
    {
        private const string DataPath = @"BasicProblems.ExcelImport.technology-brand.json";
        private readonly Dictionary<string,List<string>> raw;

        public Technology_Brand()
        {
            var json = JsonFromResourceProvider.GetJson(DataPath);
            raw = JObject.Parse(json).ToObject<Dictionary<string, List<string>>>();
        }

        public Dictionary<string, List<string>> GetCombinations()
        {
            return raw;
        }
    }
}
