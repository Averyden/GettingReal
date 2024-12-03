using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Repositories;

namespace GettingRealWPF.ViewModels
{
    public class CreateBookingViewModel
    {
        private BookingRepository bookingRepo;

        public CreateBookingViewModel(BookingRepository bookingRepository)
        {
            bookingRepo = bookingRepository;
        }

        public void CreateBooking(int id, Item bookingItems, DateTime startDate, DateTime endDate, User connectedUser)
        {
            //Booking newBooking = new Booking(id, bookingItems, startDate, endDate, connectedUser);
            //bookingRepo.Add(newBooking);
            //bookingRepo.Save(newBooking); 
        }
    }
}
