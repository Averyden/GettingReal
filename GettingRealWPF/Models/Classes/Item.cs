using GettingRealWPF.Models.Enumerations;

namespace GettingRealWPF.Models.Classes
{
    public abstract class Item
    {
        public string Name { get; set; }
        public Status Status {  get; set; }
    }
}
