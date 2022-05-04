using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace BLL
{
    public class ReportsController
    {
        private const string filePath = @"C:\Users\Alla Raiskaya\Desktop\Report.botsfile";

        public string Serialize(Dictionary<long, Report> reports)
        {
            return JsonSerializer.Serialize<Dictionary<long, Report>>(reports);
        }

        public void Save(Dictionary<long, Report> reports)
        {
            string json = Serialize(reports);

            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.WriteLine(json);
            }
        }
    }
}
