using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class Tests
    {
        public List<AbstractQuestion> Questions { get; private set; }

        public Tests()
        {
            Questions = new List<AbstractQuestion>();
        }

        // редактирование вопроса в тесте?
        public List<AbstractQuestion> EditQuestion(List<AbstractQuestion> questions, int questionNumber)
        {
            //questions[questionNumber] = new AbstractQuestion();
            return questions;
        }

        public void AddQuestion(AbstractQuestion newQuestion)
        {
            Questions.Add(newQuestion);
        }


        public void RemoveQuestionByIndex(int index)
        {
            Questions.RemoveAt(index);
        }

        public string GetAllInfo()
        {
            string info = "";

            foreach (AbstractQuestion crnt in Questions)
            {
                info += crnt.GetAllInfo();
                info += "\n";
            }

            return info;
        }
    }
}
