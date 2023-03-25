using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models
{
    public class Citizen : IIdentifiable, IBIrthable
    {
        public Citizen(string name, int age, string id, string birthdate)        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthdate;  
        }


        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string BirthDate { get; private set; }
    }
}
