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
