using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Repositories;
using System.Diagnostics;

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
            try
            {
                if (Booking == null)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error while checking bookings: {e.Message}");
                return false;
            }
        }
    }
}
