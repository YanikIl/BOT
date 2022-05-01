using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Questions
{
    public class YesOrNot : AbstractQuestion
    {
        public YesOrNot(string name)
        {
            Name = name;
            Type = "Yes or not";
        }
        public string Answer { get; set; }

        public override List<string> GetAnswer()
        {
            return new List<string>();
        }

    }
}
