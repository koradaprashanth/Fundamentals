using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems.ExcelImport
{
    public class Brand : IBrand
    {
        private const string BrandDataPath = @"BasicProblems.ExcelImport.brand.json";
        private readonly List<string> brands;

        public Brand()
        {
            var brandJson = JsonFromResourceProvider.GetJson(BrandDataPath);
            var data = JObject.Parse(brandJson).SelectToken("Brand").ToString();
            brands = JsonConvert.DeserializeObject<List<string>>(data);
        }

        public List<string> GetBrands()
        {
            return brands;
        }
    }
}
