using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RebelIdentificator.Models
{
    public class RebelIdentificationReply
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

        private string _identificationStatus;
        public string IdentificationStatus
        {
            get { return _identificationStatus; }
            set { _identificationStatus = value; }
        }
    }
}
