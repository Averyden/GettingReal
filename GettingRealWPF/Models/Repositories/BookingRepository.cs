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
    }
}
