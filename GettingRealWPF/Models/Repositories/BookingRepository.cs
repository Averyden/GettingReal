using StringHelperLibrary;

using GettingRealWPF.Models.Classes;
using System.IO;


namespace GettingRealWPF.Models.Repositories
{
    public class BookingRepository
    {
        StringHelper SH = new StringHelper();

        private List<Booking> bookings = new List<Booking>();

        private readonly string filePath = "bookings.txt"; // i have no fucking clue if we should update our DCD to include this, but it is ABSOLUTELY neccesary or else we cant save!!!!!!!!!!!!!!!!!!!!!!!!!!!

        public void Add(Booking booking)
        {
            bookings.Add(booking);
            
        }

        public void SaveBooking(Booking b)
        {
            // use stringhelper to format the saved string.
            List<string> bookingInfo = new List<string>();

            bookingInfo.Add(b.Id.ToString());
            bookingInfo.Add(b.BookingItems.ToString());
            bookingInfo.Add(b.StartDate.ToString());
            bookingInfo.Add(b.EndDate.ToString());
            bookingInfo.Add(b.ConnectedUser.ToString());

            using (StreamWriter sr = new StreamWriter(filePath))
            {
                sr.WriteLine(SH.PersistanceFormat(bookingInfo));
            }
        }

        // we should also maybeeee update DCD with this. idk just trying to look more pro here 😎
       
    }
}
