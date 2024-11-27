using GettingRealWPF.Models.Classes;
using System.IO;

namespace GettingRealWPF.Models.Repositories
{
    public class BookingRepository
    {
        private List<Booking> bookings = new List<Booking>();

        private readonly string filePath = "bookings.txt"; // i have no fucking clue if we should update our DCD to include this, but it is ABSOLUTELY neccesary or else we cant save!!!!!!!!!!!!!!!!!!!!!!!!!!!

        public void Add(Booking booking)
        {
            bookings.Add(booking);
            
        }


        // we should also maybeeee update DCD with this. idk just trying to look more pro here 😎
        private void SaveBookingToFile(Booking booking)
        {
            string serializedBooking = serializeBooking(booking);

            File.AppendAllText(filePath, serializedBooking + Environment.NewLine);
        }

        private string serializeBooking(Booking booking)
        {
            string userString = $"{booking.ConnectedUser.Name} ({booking.ConnectedUser.PhoneNumber})";
            string itemsString = ""; // We shall implement the funny little getall method later, its 11PM and im TIRED
            return $"{booking.Id};{userString};{itemsString};{booking.StartDate:yyyy-MM-dd};{booking.EndDate:yyyy-MM-dd}";
        }
    }
}
