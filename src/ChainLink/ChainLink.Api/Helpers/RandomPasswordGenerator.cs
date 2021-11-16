using System;

namespace ChainLink.Api.Helpers
{
    public class RandomPasswordGenerator
    {
        private const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        private const string UPPER_CAES = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string NUMBERS = "123456789";
        private const string SPECIALS = @"!@£$%^&*()#€";


        public string GeneratePassword(bool useLowercase, bool useUppercase, bool useNumbers, bool useSpecial,
            int passwordSize)
        {
            char[] password = new char[passwordSize];
            string charSet = ""; // Initialise to blank
            Random random = new Random();
            int counter;

            // Build up the character set to choose from
            if (useLowercase) charSet += LOWER_CASE;

            if (useUppercase) charSet += UPPER_CAES;

            if (useNumbers) charSet += NUMBERS;

            if (useSpecial) charSet += SPECIALS;

            for (counter = 0; counter < passwordSize; counter++)
            {
                password[counter] = charSet[random.Next(charSet.Length - 1)];
            }

            return String.Join(null, password);
        }
    }
}