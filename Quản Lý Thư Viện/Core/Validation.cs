using System;
using System.Drawing;
using System.Globalization;
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
        /// <inheritdoc path="https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format?redirectedfrom=MSDN"/>
        public static bool IsEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
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