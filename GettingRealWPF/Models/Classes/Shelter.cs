using GettingRealWPF.Models.Enumerations;

namespace GettingRealWPF.Models.Classes
{
    public class Shelter : Item
    {
        public Shelter(int id, string name, Status currentStatus)
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
