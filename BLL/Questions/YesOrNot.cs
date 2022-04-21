using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Questions
{
    public class YesOrNot : AbstractQuestion
    {
        public string Answer { get; set; }

        public void GetAnswer(string answer)
        {
            Answer = answer;
        }
    }
}
