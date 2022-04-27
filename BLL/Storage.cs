using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Storage
    {
        public static Dictionary<long, User> DataBase { get; set; } = new Dictionary<long, User>();

    }
}
