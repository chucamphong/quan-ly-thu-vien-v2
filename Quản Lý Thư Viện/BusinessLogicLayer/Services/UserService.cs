using System;
using System.Security.Authentication;
using System.Threading.Tasks;
using Core;
using DataAccessLayer;
using DataAccessLayer.Data;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class UserService : Service<User>
    {
        public void CheckEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Địa chỉ email không được để trống");
            }

            if (!Validation.IsEmail(email))
            {
                throw new ArgumentException("Địa chỉ email không hợp lệ");
            }
        }

        public void CheckPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Mật khẩu không được để trống");
            }
        }

        public async Task<User> Login(string email, string password)
        {
            this.CheckEmail(email);
            this.CheckPassword(password);

            User user = await Task.Run(() => (this.Data as UserData).FindByEmailAndPassword(email, password));

            if (user is null)
            {
                throw new AuthenticationException("Tài khoản hoặc mật khẩu không đúng");
            }

            return user;
        }

        protected override Data<User> Entity()
        {
            return new UserData();
        }
    }
}
