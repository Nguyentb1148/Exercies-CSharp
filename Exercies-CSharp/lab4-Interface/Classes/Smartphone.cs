using Exercies4_CSharp.Interface;

namespace Exercies4_CSharp
{
    public class Smartphone : IBrowser,ICaller
    {
        public string Browse(string url)
        {
            Validator.ValidateUrl(url);

            return $"Browsing... {url}";
        }

        public string Call(string number)
        {
            Validator.ValidatePhoneNumber(number);

            return $"Calling... {number}";
        }
    }
}