using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Repositories;
using System.Xml.Linq;

namespace GettingRealWPF.ViewModels
{
    public class CreateBookingViewModel
    {
        private ItemRepository itemRepo;
        private BookingRepository bookingRepo;
        private User activeUser;

        public CreateBookingViewModel(User activeUser)
        {
            itemRepo = new ItemRepository();
            bookingRepo = new BookingRepository();
            this.activeUser = activeUser;
        }

        public void CreateBooking()//int id, Item bookingItems, DateTime startDate, DateTime endDate, User connectedUser)
        {
            // For test purposes
            List<Item> items = itemRepo.GetAll();

            Booking b = new Booking(0, items, DateTime.Today, DateTime.Today, activeUser);

            bookingRepo.Save(b);
        }
    }
}
