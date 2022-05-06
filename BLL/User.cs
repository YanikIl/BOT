using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class User
    {
        public long Chat { get; private set; }
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}
