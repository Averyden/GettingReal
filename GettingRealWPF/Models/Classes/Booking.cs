using GettingRealWPF.Models.Repositories;

namespace GettingRealWPF.Models.Classes
{
    public class Booking
    {
        public int Id { get; set; }
        public Item BookingItems { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public User ConnectedUser { get; set; }

        public Booking(int id, Item bookingItems, DateTime startDate, DateTime endDate, User connectedUser)
        {
            Id = id;
            BookingItems = bookingItems; 
            StartDate = startDate;
            EndDate = endDate;
            ConnectedUser = connectedUser;
        }

        public override string ToString()
        {
            return $"booking id {Id} with user {ConnectedUser.ToString()}";
        }

        public override bool Equals(object obj)
        {
            if (obj is not Booking other) return false;
            return Id == other.Id &&
                   BookingItems.Equals(other.BookingItems) &&
                   ConnectedUser.Equals(other.ConnectedUser) &&
                   StartDate == other.StartDate &&
                   EndDate == other.EndDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, BookingItems, ConnectedUser, StartDate, EndDate);
        }

    }
}
