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
        public Booking Booking { get; set; }
        public Item BookingItems { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public BookingViewModel(Booking booking)
        {
            Booking = booking;
            BookingItems = booking.BookingItems;
            StartDate = booking.StartDate;
            EndDate = booking.EndDate;
        }
    }
}
