using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Repositories;
using System.Diagnostics;

namespace GettingRealWPF.ViewModels
{
    public class AccessViewModel
    {
        BookingRepository br = new BookingRepository();


        public static string Name { get; set; }
        public static string PhoneNumber { get; set; }

        public void SaveCredentials(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public void testMethodForSavingABooking()
        {
            Shelter i = new Shelter(27, "Shelter", Models.Enumerations.Status.Udlejet);
            User u = new User(Name, PhoneNumber, false);
            Booking b = new Booking(4, i, DateTime.Now, DateTime.Now, u);

            br.SaveBooking(b);

            Debug.WriteLine(br.GetAll().ToString());
        }
    }
}