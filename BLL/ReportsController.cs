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

        public string Serialize(Dictionary<long, Report> reports)
        {
            return JsonSerializer.Serialize<Dictionary<long, Report>>(reports);
        }
    }
}
