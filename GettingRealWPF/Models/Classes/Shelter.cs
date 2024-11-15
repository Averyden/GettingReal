using GettingRealWPF.Models.Enumerations;

namespace GettingRealWPF.Models.Classes
{
    public class Shelter : Item
    {
        public Shelter(string name, Status status)
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
