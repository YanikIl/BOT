using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Group
    {
        public string Name { get; set; }
        
        public List<User> Users { get; set; } = new List<User>();

        public Group()
        {
            Name = "";
            Users = new List<User>();
        }

        public Group(string name, List<User> users)
        {
            Name = name;
            Users = users;
        }
        public Group(string name)
        {
            Name = name;
            Users = new List<User>();
        }

        public Group(string name, Dictionary<long, string> nameBase)
        {
            Name = name;
            Users = new List<User>();
        }

    }
}
