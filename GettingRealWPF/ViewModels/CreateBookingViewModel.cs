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

        public void CreateBooking()
        {
            Booking booking = new Booking(
                bookingItems: new Item(0, "Store Shelter", ItemType.Shelter, Status.Available),
                startDate: DateTime.Today,
                endDate: new DateTime(2024,12,31),
                connectedUser: activeUser
            );

            bookingRepo.Add(booking); // Add the booking to the in-memory list
            bookingRepo.Save(); // Save the updated in-memory list to the file
        }
    }
}
