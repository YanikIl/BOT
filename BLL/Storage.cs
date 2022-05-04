using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Storage
    {
        public static Dictionary<long, string> NameBase { get; set; } = new Dictionary<long, string>();

        public static Dictionary<long, TestsPassController> Tests { get; set; } = new Dictionary<long, TestsPassController>();
        public static Dictionary<string, List<string>> GroupBase { get; set; } = new Dictionary<string, List<string>>();
    }
}

