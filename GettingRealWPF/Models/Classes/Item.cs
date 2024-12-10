using GettingRealWPF.Models.Enumerations;

namespace GettingRealWPF.Models.Classes
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public Status CurrentStatus {  get; set; }

        public Item(int id, string name, ItemType type, Status currentStatus)
        {
            Id = id;
            Name = name;
            Type = type;
            CurrentStatus = currentStatus;
        }

        public override string ToString()
        {
            return $"{Name}, {Type}";
        }
    }

}
