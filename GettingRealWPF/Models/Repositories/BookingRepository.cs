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

		public BookingRepository()
		{
			bookings = GetAll();

			if (bookings.Any())
			{
				Booking._id = bookings.Max(b => b.Id) + 1;
			}
			else
			{
				Booking._id = 0;
			}

			Debug.WriteLine($"Booking ID counter initialized to {Booking._id}");
		}

		public void Add(Booking booking)
		{
			bookings.Add(booking);

		}

		public void Save()
		{
			using (StreamWriter sr = new StreamWriter(filePath))
			{
				foreach (Booking b in bookings)
				{
					string formattedItem = $"{b.BookingItems.Id}|{b.BookingItems.Name}|{b.BookingItems.Type}|{b.BookingItems.CurrentStatus}";
					string formattedUser = $"{b.ConnectedUser.Name}|{b.ConnectedUser.PhoneNumber}|{b.ConnectedUser.IsAdmin}";

					List<string> bookingInfo = new List<string>
					{
						b.Id.ToString(),
						formattedItem,
						b.StartDate.ToString("dd-MM-yyyy HH:mm:ss"),
						b.EndDate.ToString("dd-MM-yyyy HH:mm:ss"),
						formattedUser
					};

					sr.WriteLine(SH.PersistanceFormat(bookingInfo));
				}
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
			List<Booking> loadedBookings = new List<Booking>();

			using (StreamReader SR = new StreamReader(filePath))
			{
				string line;
				while ((line = SR.ReadLine()) != null)
				{ 

					string[] bData = line.Split(";");
					int bookingId = int.Parse(bData[0]);

					Item item = parseItem(bData[1]);
					User conUser = parseUser(bData[4]);

					DateTime startDate;
					DateTime endDate;
					try
					{
						startDate = ParseDateTimeFormat(bData[2]);
						endDate = ParseDateTimeFormat(bData[3]);
					}
					catch (FormatException ex)
					{
						Debug.WriteLine(ex.Message);
						break;
					}
			 
					Booking loaded = new Booking(item, startDate, endDate, conUser)
					{
						Id = bookingId 
					};

					loadedBookings.Add(loaded);
				}
			}

			return loadedBookings;
		}

		// Helper method for parsing dateTime to desired date format
		public DateTime ParseDateTimeFormat(string dateToFormat)
		{
			string[] acceptedDateFormats = { "dd/MM/yyyy HH:mm:ss", "dd/MM-yyyy HH:mm:ss", "dd-MM-yyyy HH:mm:ss", "dd-MM/yyyy HH:mm:ss" };
			string dateFormat = "dd/MM/yyyy";
			// Check if provided date as string is correct format
			if (!DateTime.TryParseExact(dateToFormat, acceptedDateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime convertedDate))
			{
				throw new FormatException("Invalid DateTime format provided");
			}

			// Convert the convertedDate to string and format to the right date format
			string formattedDate = convertedDate.ToString(dateFormat);

			// Return formattedDate as DateTime
			return DateTime.Parse(formattedDate);
		}


		public Booking GetBookingsForUser(User user) // Yes i know it is in plural, but in this stage and probably forever, we will limit the amount of bookings a user has to just one.

		{
			string nameToCheck = user.Name; // we will perform the checks through the userName
			string safetyNet = user.PhoneNumber;



			List<Booking> bookings = GetAll();
			foreach (var booking in bookings)
			{
				if (booking.ConnectedUser.Name == nameToCheck && booking.ConnectedUser.PhoneNumber == safetyNet) // Check if a specific user belongs to the booking
				{
					return booking;
				}
			}
			return null; // if not found, return null
		}

		public void Delete(Booking bookingToDelete)
		{
			bookings = GetAll(); 
			bookings.RemoveAll(b => b.Id == bookingToDelete.Id); 
			Save(); 
		}


		// Helper methods so that we can reconstruct objects for example reconstructing the item class for the connected item to a certain booking.
		private Item ParseItem(string data)
		{
			try
			{
				string[] itemParts = data.Split('|');
				if (itemParts.Length < 4)
					throw new ArgumentException("Invalid item data format.");

				if (!int.TryParse(itemParts[0], out int itemId)) // index 0 is Booking ID
					throw new ArgumentException($"Invalid item ID: {itemParts[0]}");
				
				if (!Enum.TryParse<ItemType>(itemParts[2], out var itemType)) // index 2 is the type of item
					throw new ArgumentException($"Invalid ItemType: {itemParts[2]}");

				if (!Enum.TryParse<Status>(itemParts[3], out var status)) // index 3 is the status of the item
					throw new ArgumentException($"Invalid Status: {itemParts[3]}");

				return new Item(itemId, itemParts[1], itemType, status);
			}
			catch (Exception ex)
			{
				Debug.WriteLine($"Error parsing item: {ex.Message}");
				throw;
			}
		}


		private User ParseUser(string data)
		{
			string[] userParts = data.Split("|");
			return new User(userParts[0], userParts[1], bool.Parse(userParts[2]));
		}


	}
}
