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

        public void Save(Booking b)
        {
            // We format the item and user, so we can reconstruct them later on.
            string formattedItem = $"{b.BookingItems.Id}|{b.BookingItems.Name}|{b.BookingItems.Type}|{b.BookingItems.CurrentStatus}";


            string formattedUser = $"{b.ConnectedUser.Name}|{b.ConnectedUser.PhoneNumber}|{b.ConnectedUser.IsAdmin}";

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

        public Booking Get(int id)
        {
            Booking? foundBooking = null;

            foreach (Booking booking in bookings)
            {
                if (booking.Id == id)
                {
                    foundBooking = booking;
                }
            }
            return foundBooking;
        }


        public List<Booking> GetAll()
        {

            using (StreamReader SR = new StreamReader(filePath))
            {
                string line;
                while ((line = SR.ReadLine()) != null)
                {
                    string[] dateFormats = {
                        "dd-MM-yyyy",
                        "dd/MM-yyyy",
                        "MM-dd-yyyy",
                        "MM/dd-yyyy",
                        "dd-MM-yyyy HH:mm:ss",
                        "MM-dd-yyyy hh:mm:ss tt",
                        "dd/MM/yyyy hh:mm:ss tt"
                    };
                    string[] bData = line.Split(";");

                    string bID = bData[0]; // Should give us the booking id?
                    Item item = parseItem(bData[1]);
                    string bStartDate = bData[2]; // Start Date
                    string bEndDate = bData[3]; // End Date

                  

                    string cleanStartDate = bStartDate.Split(' ')[0].Trim();
                    string cleanEndDate = bEndDate.Split(' ')[0].Trim();

                    DateTime parsedStartDate;
                    DateTime parsedEndDate;

                    DateTime startDate = DateTime.Now;
                    DateTime endDate = DateTime.Now;

                    if (DateTime.TryParseExact(cleanStartDate, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedStartDate))
                    {
                        startDate = parsedStartDate.Date;
                    }
                    else
                    {
                        Debug.WriteLine($"The start date '{bStartDate}' does not match the allowed formats.");
                    }

                    if (DateTime.TryParseExact(cleanEndDate, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedEndDate))
                    {
                        endDate = parsedEndDate.Date;
                    }
                    else
                    {
                        Debug.WriteLine($"The end date '{bEndDate}' does not match the allowed formats.");
                    }


                    //DateTime startDate = DateTime.ParseExact(bData[2], "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                    //DateTime endDate = DateTime.ParseExact(bData[3], "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);



                    User conUser = parseUser(bData[4]); // Maybe we should actually split up the name and phone numbers, so that we can check later on.

                    Booking loaded = new Booking(int.Parse(bID), item, startDate, endDate, conUser);
                    bookings.Add(loaded);
                }
            }
            return bookings;
        }


        
        public Booking GetBookingsForUser(User u) // Yes i know it is in plural, but in this stage and probably forever, we will limit the amount of bookings a user has to just one.

        {
            string nameToCheck = u.Name; // we will perform the checks through the userName
            string safetyNet = u.PhoneNumber;



            List<Booking> bookings = GetAll();
            foreach (var b in bookings)
            {
                if (b.ConnectedUser.Name == nameToCheck && b.ConnectedUser.PhoneNumber == safetyNet) // Check if a specific user belongs to the booking
                {
                    return b;
                }
            }
            return null; // if not found, return null
        }

        // we should also maybeeee update DCD with this. idk just trying to look more pro here 😎


        // Helper methods so that we can reconstruct objects for example reconstructing the item class for the connected item to a certain booking.
        private Item parseItem(string data)
        {
            try
            {
                string[] itemParts = data.Split('|');
                if (itemParts.Length < 4)
                    throw new ArgumentException("Invalid item data format.");

                if (!int.TryParse(itemParts[0], out int itemId))
                    throw new ArgumentException($"Invalid item ID: {itemParts[0]}");

                if (!Enum.TryParse<ItemType>(itemParts[2], out var itemType))
                    throw new ArgumentException($"Invalid ItemType: {itemParts[2]}");

                if (!Enum.TryParse<Status>(itemParts[3], out var status))
                    throw new ArgumentException($"Invalid Status: {itemParts[3]}");

                return new Item(itemId, itemParts[1], itemType, status);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error parsing item: {ex.Message}");
                throw;
            }
        }


        private User parseUser(string data)
        {
            string[] userParts = data.Split("|");
            return new User(userParts[0], userParts[1], bool.Parse(userParts[2]));
        }


    }
}
