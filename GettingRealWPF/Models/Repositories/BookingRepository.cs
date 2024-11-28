using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Enumerations;
using StringHelperLibrary;
using System.Diagnostics;
using System.Globalization;
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
            // We format the item and user, so we can reconstruct them later on.
            string formattedItem = $"{b.bookingItem.Id}:{b.bookingItem.Name}:{b.bookingItem.CurrentStatus}";
            string formattedUser = $"{b.ConnectedUser.Name}:{b.ConnectedUser.PhoneNumber}:{b.ConnectedUser.IsAdmin}";

            // use stringhelper to format the saved string.
            List<string> bookingInfo =
            [
                b.Id.ToString(),
                formattedItem,
                b.StartDate.ToString(),
                b.EndDate.ToString(),
                formattedUser
            ];

            using (StreamWriter sr = new StreamWriter(filePath, append: true))
            {
                sr.WriteLine(SH.PersistanceFormat(bookingInfo));
                Debug.WriteLine("hg");
            }


        }

        public List<Booking> GetAll()
        {
            List<Booking> bookings = new List<Booking>();

            using (StreamReader SR = new StreamReader(filePath))
            {
                string line;
                while ((line = SR.ReadLine()) != null)
                {
                    string[] bData = line.Split(";");

                    string bID = bData[0]; // Should give us the booking id?
                    Item item = parseItem(bData[1]);
                    DateTime startDate = DateTime.ParseExact(bData[2], "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                    DateTime endDate = DateTime.ParseExact(bData[3], "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                    User conUser = parseUser(bData[4]); // Maybe we should actually split up the name and phone numbers, so that we can check later on.

                    Booking loaded = new Booking(int.Parse(bID), item, startDate, endDate, conUser);

                }
            }
            return bookings;
        }

        public string GetBookingsForUser(User u)
        {
            string nameToCheck = u.Name; // we will perform the checks through the userName
        }

        // we should also maybeeee update DCD with this. idk just trying to look more pro here 😎


        // Helper methods so that we can reconstruct objects for example reconstructing the item class for the connected item to a certain booking.
        private Item parseItem(string data)
        {
            string[] itemParts = data.Split(':');
            if (itemParts[1] == "Shelter")
            {
                return new Shelter(int.Parse(itemParts[0]), itemParts[1], (Status)Enum.Parse(typeof(Status), itemParts[2]));
            
            } else
            {
                return new Canoe(int.Parse(itemParts[0]), itemParts[1], (Status)Enum.Parse(typeof(Status), itemParts[2]));
            }
            
        }

        private User parseUser(string data) 
        {
            string[] userParts = data.Split(":");
            return new User(userParts[0], userParts[1], bool.Parse(userParts[2]));
        }


    }
}
