using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace BLL
{
    public class TestsController
    {
        private const string filePath = @"Tests.botsfile";

        public string Serialize(List<Test> tests)
        {
            return JsonSerializer.Serialize<List<Test>>(tests);
        }

        public List<Test> Decerialize(string json)
        {
            if (json == null)
            {
                throw new ArgumentNullException("json");

            }
            else
            {
                return JsonSerializer.Deserialize<List<Test>>(json);
            }
        }

        public void Save(List<Test> tests)
        {
            string json = Serialize(tests);

            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.WriteLine(json);
            }
        }

        public List<Test> Load()
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string json = sr.ReadLine();
                return Decerialize(json);
            }
        }
    }
}
