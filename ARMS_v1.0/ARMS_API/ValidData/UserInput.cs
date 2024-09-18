using System.Globalization;
using System.Text;
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
        public string RemoveDiacritics(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            var normalizedText = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedText)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        // Function to normalize and remove diacritics
        public string NormalizeText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            return RemoveDiacritics(text).ToLower();
        }
    }
}
