

using Gateway.Ocelot.Sample.Users.Model;

namespace Gateway.Ocelot.Sample.Users.Service
{
    public class UserRepository : List<Model.User>, IUserRepository
    {
        private readonly static List<Model.User> _users = UsersSeed();

        private static List<User> UsersSeed()
        {
            var result = new List<User>()
            {
                new User
                {
                    Id = 1,
                    Name = "Admin",
                    Passwword = "Password"                    
                },
                new User
                {
                    Id = 2,
                    Name = "User01",
                    Passwword = "Password"
                },
                new User {
                    Id = 3, 
                    Name = "User02", 
                    Passwword = "Password"
                }
            };

            return result;
        }

        public User Get(int id)
        {
            return _users.FirstOrDefault(f => f.Id == id);
        }

        public List<User> GetAll()
        {
            return _users.ToList();
        }
    }
}
