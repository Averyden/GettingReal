using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Enumerations;
using System.IO;
using System.Windows.Controls;

namespace GettingRealWPF.Models.Repositories
{
    public class ItemRepository
    {
        private List<Item> items = new List<Item>();
        private string filePath = "items.txt";


        public void AddItem(Item item)
        {
            items.Add(item);
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

                    if ()
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
