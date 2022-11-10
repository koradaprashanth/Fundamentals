using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems.ExcelImport
{
    public interface ITechnology_Brand
    {
        Dictionary<string, List<string>> GetCombinations();
    }
}
