using StringHelperLibrary;

using GettingRealWPF.Models.Classes;
using System.IO;
using System.Diagnostics;


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
            List<string> bookingInfo =
            [
                b.Id.ToString(),
                b.bookingItem.ToString(),
                b.StartDate.ToString(),
                b.EndDate.ToString(),
                b.ConnectedUser.ToString(),
            ];

            using (StreamWriter sr = new StreamWriter(filePath, append: true))
            {
                sr.WriteLine(SH.PersistanceFormat(bookingInfo));
                Debug.WriteLine("hg");
            }


        }

        // we should also maybeeee update DCD with this. idk just trying to look more pro here 😎
       
    }
}
