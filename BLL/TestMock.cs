using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TestMock
    {
        public static Test GetTestsListMock()
        {
            Test testExample = new Test("TestExample")
            {
                questions = new List<AbstractQuestion>
                {
                    new OpenQuestion()
                    {

                    }
                }
            };

            return testExample;
        }
    }
}
