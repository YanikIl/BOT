using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Questions
{
    public class RadioButtonQuestion: AbstractQuestion
    {
        public List<string> AnswerOptions;

        public List<string> GetAnswerOptions()
        {
            return AnswerOptions;
        }

        public void AddAnswer(string text, List<string> answerOptions)
        {
            answerOptions.Add(text);
        }

    }
}
