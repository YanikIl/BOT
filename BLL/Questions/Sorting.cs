using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Questions
{
    public class Sorting: AbstractQuestion
    {
        public List<string> AnswerOptions;
        public Sorting(string name)
        {
            Name = name;
            Type = "Sorting";
        }
        public override List<string> GetAnswer()
        {
            return AnswerOptions;
        }

    }
}
