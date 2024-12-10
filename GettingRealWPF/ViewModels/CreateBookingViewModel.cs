using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Commands;
using GettingRealWPF.Models.Enumerations;
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
            // For testing

            Booking booking = new Booking(
                id: 0, 
                bookingItems: new Item(0, "Store Shelter", ItemType.Shelter, Status.Available), 
                startDate: DateTime.Today, 
                endDate: DateTime.Today,
                connectedUser: activeUser
            );
            bookingRepo.Add(booking);
            bookingRepo.Save(bookingRepo.GetAll());
        }
    }
}
