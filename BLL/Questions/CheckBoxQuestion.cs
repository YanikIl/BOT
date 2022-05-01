using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Questions
{
    public class CheckBoxQuestion: AbstractQuestion
    {
        private bool _isYes;
        public bool IsYes
        {
            get { return _isYes; }
            set { _isYes = value; }
        }

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
