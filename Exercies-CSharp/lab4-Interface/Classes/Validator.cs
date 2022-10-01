using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;

namespace Exercies4_CSharp
{
    public class Validator
    {
        public static void ValidateNotNull(string value,string type)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{type} cannot be null");
            }
        }

        public static void ValidatePhoneNumber(string number)
        {
            if (number.Any(x=> char.IsLetter(x)) || number.Any(x=>char.IsWhiteSpace(x)))
            {
                throw new ArgumentException("Invalid number!");
            }
        }
        public static void ValidateUrl(string url)
        {
            if (url.Any(x=> char.IsNumber(x)) || url.Any(x=>char.IsWhiteSpace(x)))
            {
                throw new ArgumentException("Invalid Url!");
            }
        }
    }
}