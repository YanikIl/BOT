namespace BLL
{
    public class AbstractQuestion
    {
        public string Name { get; set; }
        public string Type { get; protected set; }

        public void CreateQuestion (string name)
        {
            Name = name;
        }
    }
}