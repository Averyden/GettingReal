using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealWPF.ViewModels
{
    public class BookingViewModel
    {
        private Booking booking;
        public List<ItemRepository> BookingItems { get; set; } = new List<ItemRepository>();
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public BookingViewModel()
        {
            
        }
    }
}
