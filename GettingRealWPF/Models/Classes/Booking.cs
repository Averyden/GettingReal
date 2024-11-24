using GettingRealWPF.Models.Repositories;

namespace GettingRealWPF.Models.Classes
{
    public class Booking
    {
        public int Id { get; set; }
        public List<ItemRepository> BookingItems { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public User ConnectedUser { get; set; }

        public Booking(int id, List<ItemRepository> bookingItems, DateTime startDate, DateTime endDate, User connectedUser)
        {
            Id = id;
            BookingItems = bookingItems;
            StartDate = startDate;
            EndDate = endDate;
            ConnectedUser = connectedUser;
        }
    }
}
