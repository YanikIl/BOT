using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Questions
{
    public class YesOrNot : AbstractQuestion
    {
        private bool _isYes;
        private bool _isNo;
        private string _answerYes;
        private string _answerNo;
        public bool IsYes 
        {
            get { return _isYes; }
            set { _isYes = value; }
        }
        public bool IsNo
        {
            get { return _isNo; }
            set { _isNo = value; }
        }

        public string AnswerYes
        {
            get { return _answerYes; }
            set { _answerYes = value; }
        }
        public string AnswerNo
        {
            get { return _answerNo; }
            set { _answerNo = value; }
        }

    }
}
