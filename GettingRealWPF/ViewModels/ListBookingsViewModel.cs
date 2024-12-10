using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealWPF.ViewModels
{
    public class ListBookingsViewModel
    {
        private BookingRepository bookingRepo = new BookingRepository();
        
        public Booking Booking { get; set; } 
        public bool HasBooking { get; set; }
        public bool IsBookingEmpty { get; set; }

        public ListBookingsViewModel(User activeUser)
        {
            Booking = bookingRepo.GetBookingsForUser(activeUser);
            HasBooking = UpdateHasBooking();
            IsBookingEmpty = !UpdateHasBooking();
        }

        private bool UpdateHasBooking()
        {
            if (string.IsNullOrWhiteSpace(Booking.ToString()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
