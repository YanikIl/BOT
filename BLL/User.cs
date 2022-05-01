using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class User
    {
        public string Name { get; set; }
        //public string Group { get; set; }

        public User(string name)
        {
            Name = name;
            //Group = "Other";
        }

        //public void ChangeName(string newName)
        //{
        //    Name = newName;
        //}

        //public void ChangeGroup(string newGroup)
        //{
        //    Group = newGroup;
        //}
    }
}
