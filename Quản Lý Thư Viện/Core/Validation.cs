using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace Core
{
    public class Validation
    {
        /// <summary>
        /// Kiểm tra tính hợp lệ của địa chỉ email.
        /// </summary>
        /// <param name="email">Địa chỉ email.</param>
        /// <returns>Trả về <see langword="true"/> nếu đúng và <see langword="false"/> nếu sai.</returns>
        public static bool IsEmail(string email)
        {
            const string pattern =
                       @"^([0-9a-zA-Z]" + //Start with a digit or alphabetical
                       @"([\+\-_\.][0-9a-zA-Z]+)*" + // No continuous or ending +-_. chars in email
                       @")+" +
                       @"@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$";
            return Regex.IsMatch(email, pattern);
        }

        /// <summary>
        /// Báo lỗi cho người dùng.
        /// </summary>
        /// <param name="textBox">Textbox cần đổi màu.</param>
        /// <param name="lblError">Label để hiển thị tin nhắn lỗi.</param>
        /// <param name="message">Tin nhắn lỗi.</param>
        public static void SetErrorTextBox(GunaTextBox textBox, Label lblError, string message)
        {
            textBox.BorderColor = textBox.FocusedBorderColor = Color.FromArgb(233, 75, 98);
            lblError.Text = message;
        }

        /// <summary>
        /// Xóa báo lỗi.
        /// </summary>
        /// <param name="textBox">Textbox cần xóa màu.</param>
        /// <param name="lblError">Label cần xóa tin nhắn lỗi.</param>
        public static void ClearErrorTextBox(GunaTextBox textBox, Label lblError)
        {
            textBox.BorderColor = textBox.FocusedBorderColor = Color.FromArgb(43, 43, 43);
            lblError.Text = string.Empty;
        }
    }
}