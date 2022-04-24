using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Group
    {
        public string GroupsName { get; set; }

        public Group(string groupsName)
        {
            GroupsName = groupsName;
        }
    }
}
