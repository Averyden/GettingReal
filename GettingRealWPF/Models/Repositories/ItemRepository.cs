using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Enumerations;
using System.IO;
using System.Windows.Controls;

namespace GettingRealWPF.Models.Repositories
{
    public class ItemRepository
    {
        private List<Item> items = new List<Item>()
        {
            new Item(0, "Smukke Shelter", ItemType.Shelter, Status.Available),
            new Item(1, "Lange Kano", ItemType.Canoe, Status.Available),
            new Item(2, "KÆMPE Kano", ItemType.Canoe, Status.Available),

        };
        private string filePath = "items.txt";
        public void Add(Item item)
        {
            items.Add(item);
        }

        public List<Item> GetAll()
        {
            return items;
        }


        public void LoadAll()
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                int lineCount = File.ReadLines(filePath).Count();

                string line;

                while((line = reader.ReadLine()) != null)
                {
                    string[] info = line.Split(';');

                    
                }
            }
        }

        //public Status GetStatus(string name)
        //{
        //    foreach (Item item in items)
        //    {
        //        if (item.Name == name)
        //        {
        //            return item.Status;
        //        }
        //    }
        //    throw new InvalidOperationException($"Could not find the item: {name}");
        //}
    }
}
