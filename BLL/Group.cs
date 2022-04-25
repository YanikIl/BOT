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
        
        public List<User> Users { get; set; }


        public Group(string name)
        {
            Name = name;
        }

        public void AddUser(User user)
        {
            if (user.Group == Name)
            {
                Users.Add(user);
            }
        }

        
    }
}
