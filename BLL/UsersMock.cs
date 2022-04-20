namespace BLL
{
    public class UsersMock
    {

        public static List<User> GetUsersListMock()
        {
            List<User> usersMock = new List<User> {
                new User("Tom Bombadil"),
                new User("Bob"),
                new User("Sam"),
                new User("Anna Li"),
                new User("Cheburator"),
                new User("Ivan"),
                new User("Boris"),
                new User("Andreika"),
                new User("Ebobo Ololo"),
                new User("Susanna"),
            };
            return usersMock;
        }
    }
}