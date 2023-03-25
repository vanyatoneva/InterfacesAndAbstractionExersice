using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models
{
    public class Pet : IBIrthable
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            BirthDate = birthdate;
        }
        public string Name { get; private set; }

        public string BirthDate { get; private set; }
    }
}
