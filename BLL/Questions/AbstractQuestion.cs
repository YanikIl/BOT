namespace BLL
{
    public abstract class AbstractQuestion
    {
        private string _test;
        private string _question;
        public string Test
        { 
            get { return _test; }
            set { _test = value; }
        }
        public string Question
        {
            get { return _question; }
            set { _question = value; }
        }
        public string Type { get; protected set; }

    }
}