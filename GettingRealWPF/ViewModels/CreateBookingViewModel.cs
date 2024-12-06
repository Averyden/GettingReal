using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Commands;
using GettingRealWPF.Models.Repositories;
using System.Windows.Input;

namespace GettingRealWPF.ViewModels
{
    public class CreateBookingViewModel
    {
        private ItemRepository itemRepo = new ItemRepository();
        private BookingRepository bookingRepo = new BookingRepository();
        private User activeUser;

        public ICommand CreateBookingCmd { get; } = new CreateBookingCmd();

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
