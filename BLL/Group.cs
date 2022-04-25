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

        public Group(string groupsName)
        {
            Name = groupsName;
        }
    }
}
