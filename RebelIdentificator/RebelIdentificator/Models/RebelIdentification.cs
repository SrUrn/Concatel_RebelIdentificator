using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RebelIdentificator.Models
{
    public class RebelIdentification
    {
        private static List<Rebel> _rebelList = new List<Rebel>();

        public static void Add(Rebel rebel)
        {
            _rebelList.Add(rebel);
        }

        public static List<Rebel> GetAllRebel()
        {
            return _rebelList;
        }
    }
}
