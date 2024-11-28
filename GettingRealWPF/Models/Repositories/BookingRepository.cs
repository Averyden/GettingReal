using GettingRealWPF.Models.Classes;
using StringHelperLibrary;
using System.Diagnostics;
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

        public List<string> GetAll() // Normally we'd get a list of bookings considering the method name, but we return a list of all booking ids due to our contextual mess.
        { // On another note, this method only gets called when the ADMIN logs in.
            List<string> bookings = new List<string>();

            using (StreamReader SR = new StreamReader(filePath))
            {
                string line;
                while ((line = SR.ReadLine()) != null)
                {
                    string[] bData = line.Split(";");

                    string bID = bData[0]; // Should give us the booking id?

                    bookings.Add($"Booking: {bID}");
                }
            }
            return bookings;
        }

        // we should also maybeeee update DCD with this. idk just trying to look more pro here 😎

    }
}
