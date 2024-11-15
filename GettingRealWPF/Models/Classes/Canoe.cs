using GettingRealWPF.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealWPF.Models.Classes
{
    public class Canoe : Item
    {
        public Canoe(string name, Status status)
        {
            Name = name;
            Status = status;
        }
        public override string ToString()
        {
            return $"{Name}: {Status}";
        }
    }
}
