using System.Threading.Tasks;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public interface IUserService : IService<User>
    {
        Task<User> Login(string email, string password);
    }
}