using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string URL)
        {
            if (!ValidateURL(URL))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {URL}!"; 
        }

        public string Call(string phoneNo)
        {
            if (!ValidatePhoneNo(phoneNo))
            {
                throw new ArgumentException($"Invalid number!");
            }
            return $"Calling... {phoneNo}";
        }

        public bool ValidatePhoneNo(string phoneNo) => phoneNo.All(c => char.IsDigit(c));

        public bool ValidateURL(string URL) => (URL.All(c => !char.IsDigit(c)));
    }
}
