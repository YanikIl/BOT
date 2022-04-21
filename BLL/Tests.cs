using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class Tests
    {
        public List<AbstractQuestion> Questions;


        // редактирование вопроса в тесте
        public List<AbstractQuestion> EditQuestion(List<AbstractQuestion> questions, int questionNumber)
        {
            questions[questionNumber] = new AbstractQuestion();
            return questions;
        }

        // добавление нового вопроса в тест
        public void AddQuestion(AbstractQuestion newQuestion)
        {
            Questions.Add(newQuestion);
        }
    }
}
