using System.Security.Authentication;
using System.Threading.Tasks;
using Core;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class UserService : Service<User>, IUserService
    {
        public async Task<User> Login(string email, string password)
        {
            string hashPassword = MD5.Hash(password);

            User user = await Task.Run(() => (this.Data as UserData).FindByEmailAndPassword(email, hashPassword));

            if (user is null)
            {
                throw new AuthenticationException("Tài khoản hoặc mật khẩu không đúng");
            }

            return user;
        }

        protected override IData<User> Entity()
        {
            return new UserData();
        }
    }
}
