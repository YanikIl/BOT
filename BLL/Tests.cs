using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Test
    {
        public string Name {get; set;}
        public List<AbstractQuestion> questions { get; set; } = new List<AbstractQuestion>();

        public Test(string name)
        {
            Name = name;
        }

        //public Test GetClone()
        //{
        //    string cloneName = Name;
        //    List<AbstractQuestion> cloneQ = new List<AbstractQuestion>();
        //    foreach (AbstractQuestion question in questions)
        //    {
        //        cloneQ.Add(question.Clone());
        //    }
        //    return new Test(cloneName)
        //    {
        //        questions = cloneQ
        //    };
        //}
    }
}
