using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TestMock
    {
        public static List<Test> GetTestsListMock()
        {
            List<Test> testsMock = new List<Test> {
                new Test("Test 1"),
                new Test("Test 2"),
                new Test("Test 3"),
                new Test("Test 4"),
                new Test("Test 5"),
            };
            return testsMock;
        }
    }
}
