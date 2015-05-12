using System;
using System.Text.RegularExpressions;

namespace DDDValidation.Validation
{
    public class EmailAssertionConcern
    {
        public static void AssertEmailFormat(string email, string message)
        {
            if (string.IsNullOrEmpty(email))
                throw new InvalidOperationException(message);

            if (!Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                throw new InvalidOperationException(message);
        }
    }
}
