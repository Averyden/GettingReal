using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Enumerations;
using System.Windows.Controls;

namespace GettingRealWPF.Models.Repositories
{
    public class ItemRepository
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public Status GetStatus(string name)
        {
            foreach (Item item in items)
            {
                if (item.Name == name)
                {
                    return item.Status;
                }
            }
            throw new InvalidOperationException($"Could not find the item: {name}");
        }
    }
}
