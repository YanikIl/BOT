using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Questions
{
    public class CheckBoxQuestion: AbstractQuestion
    {
        public List<string> AnswerOptions;
        public CheckBoxQuestion(string name)
        {
            Name = name;
            Type = "Check box question";
        }
        public override List<string> GetAnswer()
        {
            return AnswerOptions;
        }

    }
}
