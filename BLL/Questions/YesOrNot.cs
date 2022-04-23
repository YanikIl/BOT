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
        public bool IsYes 
        {
            get { return _isYes; }
            set { _isYes = value; }
        }

    }
}
