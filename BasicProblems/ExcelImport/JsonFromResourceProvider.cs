using System.IO;
using System.Reflection;
using System.Text;

namespace BasicProblems.ExcelImport
{
    public static class JsonFromResourceProvider
    {
        public static string GetJson(string embeddedResourceFullName, Assembly assembly = null)
        {
            assembly = assembly ?? Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(embeddedResourceFullName);
            return StreamToString(stream);
        }

        private static string StreamToString(Stream stream)
        {
            stream.Position = 0;
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
