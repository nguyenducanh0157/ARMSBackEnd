using System.Text.RegularExpressions;

namespace ARMS_API.ValidData
{
    public class UserInput
    {
        public bool IsValidEmail(string email)
        {
            //example@gmail.com
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            //+84972276578
            var phonePattern = @"^\+?\d{10,15}$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }

    }
}
