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
        public string Name { get; set; }
        public Canoe(int id, string name, Status currentStatus)
        {
            Id = id;
            Name = name;
            CurrentStatus = currentStatus;
        }
        public override string ToString()
        {
            return $"{Name}: {CurrentStatus}";
        }
    }
}
