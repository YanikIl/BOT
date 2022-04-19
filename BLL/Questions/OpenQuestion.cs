using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Questions
{
    public class OpenQuestion: AbstractQuestion
    {
        public string Answer { get; set; }
        public void WriteAnswer(string text)
        {
            Answer = text;
        }
    }
}
