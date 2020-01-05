using System.Text;

namespace Core
{
    public class MD5
    {
        public static string Hash(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder hash = new StringBuilder();

                foreach (byte b in data)
                {
                    hash.Append(b.ToString("x2"));
                }

                return hash.ToString();
            }
        }
    }
}
