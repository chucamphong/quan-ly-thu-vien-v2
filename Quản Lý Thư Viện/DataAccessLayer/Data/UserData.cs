using System.Linq;
using DataTransferObject;

namespace DataAccessLayer
{
    public class UserData : Data<User>, IUserData
    {
        public User FindByEmailAndPassword(string email, string password)
        {
            return this.Entity.FirstOrDefault(user => user.Email == email && user.Password == password);
        }
    }
}
