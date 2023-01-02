using System.Text.RegularExpressions;

namespace addressbook.Helper
{
    public static class PasswordChecker
    {
        private static Regex regexPass = new Regex(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$");

        private static Regex regexEmail = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");

        private static Regex regexPhoneNumber = new Regex(@"^(\+\d{1,2}\s?)?1?\-?\.?\s?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$");
        public static bool ValidatePassword(string password)
        {
            if (regexPass.IsMatch(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ComparePassword(string userPass, string dbPass)
        {
            if (userPass == dbPass)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool ValidateEmail(string email)
        {
            if (regexEmail.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidatePhone(string number)
        {
            if (regexPhoneNumber.IsMatch(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
