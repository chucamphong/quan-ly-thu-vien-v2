using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Data;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class UserService
    {
        private UserData userData = new UserData();

        public void CheckEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Địa chỉ email không được để trống");
            }

            EmailAddressAttribute emailChecker = new EmailAddressAttribute();

            if (!emailChecker.IsValid(email))
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

            User user = await Task.Run(() => this.userData.FindByEmailAndPassword(email, password));

            if (user is null)
            {
                throw new AuthenticationException("Tài khoản hoặc mật khẩu không đúng");
            }

            return user;
        }
    }
}
