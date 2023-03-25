﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public interface ICallable
    {
        public string Call(string phoneNo);

        public bool ValidatePhoneNo(string phoneNo);
    }
}
