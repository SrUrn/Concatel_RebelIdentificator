using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RebelIdentificator.Models
{
    public class Rebel 
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _planet;
        public string Planet
        {
            get { return _planet; }
            set { _planet = value; }
        }

        public override string ToString()
        {
            return $"{Name ?? "null"} {Planet ?? "null"}";
        }
    }
}

