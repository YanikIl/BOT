namespace BLL
{
    public abstract class AbstractQuestion
    {
        private string _question;
        private string _type;
        public string Question
        {
            get { return _question; }
            set { _question = value; }
        }
        public string Type 
        { 
            get { return _type; }
            protected set { ;} 
        }

    }
}