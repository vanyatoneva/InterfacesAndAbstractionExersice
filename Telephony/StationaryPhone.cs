using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string phoneNo)
        {
            if (!ValidatePhoneNo(phoneNo))
            {
                throw new ArgumentException($"Invalid number!");
            }
            return $"Dialing... {phoneNo}";
        }

        public bool ValidatePhoneNo(string phoneNo) => phoneNo.All(c => char.IsDigit(c));
    }
}
