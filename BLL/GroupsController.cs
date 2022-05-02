using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace BLL
{
    public class GroupsController
    {
        private const string filePath = @"Groups.botsfile";

        public string Serialize(List<Group> groups)
        {
            return JsonSerializer.Serialize<List<Group>>(groups);
        }

        public List<Group> Decerialize(string json)
        {
            if (json == null)
            {
                throw new ArgumentNullException("json");
            }
            else
            {
                return JsonSerializer.Deserialize<List<Group>>(json);
            }
        }

        public void Save(List<Group> groups)
        {
            string json = Serialize(groups);

            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.WriteLine(json);
            }
        }

        public List<Group> Load()
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string json = sr.ReadLine();
                return Decerialize(json);
            }
        }
    }
}
