using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace BLL
{
    public class TestsStorage
    {
        public List<Test> Tests { get; set; }

        private static TestsStorage _instance;

        private TestsStorage()
        {
            Tests = new List<Test>();
        }

        public static TestsStorage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TestsStorage();
            }

            return _instance;
        }
    }
}
