using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Questions
{
    public class OpenQuestion: AbstractQuestion
    {
        public string _answer;
        public string Answer 
        {
            get { return _answer;}
            set { _answer = value;}
        }
        public OpenQuestion(string name)
        {
            Name = name;
            Type = "Open question";
        }
        public override List<string> GetAnswer()
        {
            List<string> answers = new List<string> { _answer };
            return answers;
        }

    }
}
