using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Repositories;

namespace GettingRealWPF.ViewModels
{
    public class CreateBookingViewModel
    {
        private ItemRepository itemRepo = new ItemRepository();
        private BookingRepository bookingRepo = new BookingRepository();
        private User activeUser;

        public CreateBookingViewModel(User activeUser)
        {
            this.activeUser = activeUser;
        }

        public void CreateBooking()//int id, Item bookingItems, DateTime startDate, DateTime endDate, User connectedUser)
        {
            // For test purposes
            List<Item> items = itemRepo.GetAll();

            Booking booking = new Booking(
                id: 0, 
                bookingItems: items, 
                startDate: DateTime.Today, 
                endDate: DateTime.Today, 
                connectedUser: activeUser
            );

            bookingRepo.Save(booking);
        }
    }
}
