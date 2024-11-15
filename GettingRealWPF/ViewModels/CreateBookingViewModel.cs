using GettingRealWPF.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealWPF.ViewModels
{
    public class CreateBookingViewModel
    {
        private ItemRepository itemRepository = new ItemRepository();
        public ObservableCollection<ItemViewModel> ItemsVM { get; set; }

        public CreateBookingViewModel()
        {
            ItemsVM = new ObservableCollection<ItemViewModel>();
            
            foreach (Item item in ItemsVM)
        }
    }
}
