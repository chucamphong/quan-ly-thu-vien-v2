using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer.Data
{
    public class UserData : Data<User>
    {
        public User FindByEmailAndPassword(string email, string password)
        {
            return this.Entity.FirstOrDefault(user => user.Email == email && user.Password == password);
        }
    }
}
