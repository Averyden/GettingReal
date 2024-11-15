using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Enumerations;
using System.Reflection.Metadata;

namespace GettingRealWPF.ViewModels
{
    public class ItemViewModel
    {
        private Item item;

        public string Name { get; set; }
        public Status Status { get; set; }

        public ItemViewModel(Item item)
        {
            this.item = item;
            Name = item.Name;
            Status = item.Status;
        }
    }
}
