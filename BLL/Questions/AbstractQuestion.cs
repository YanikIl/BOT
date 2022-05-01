namespace BLL
{
    public abstract class AbstractQuestion
    {
        public string Name { get; set; }
        public string Type { get; protected set; }

        public string GetAllInfo()
        {
            return $"{Name}, {Type}";
        }
        public abstract List<string> GetAnswer();
    }
}