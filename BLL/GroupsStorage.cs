using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace BLL
{
    public class GroupsStorage
    {
        public List<Group> Groups { get; set; }

        private static GroupsStorage _instance;

        private GroupsStorage()
        {
            Groups = new List<Group>();
        }

        public static GroupsStorage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GroupsStorage();
            }

            return _instance;
        }

        

    }
}
