using Gateway.Ocelot.Sample.Users.Model;

namespace Gateway.Ocelot.Sample.Users.Service
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User Get(int id);
    }
}
