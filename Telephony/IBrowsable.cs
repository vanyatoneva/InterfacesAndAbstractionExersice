﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public interface IBrowsable
    {
        public string Browse(string URL);

        public bool ValidateURL(string URL);    
    }
}
