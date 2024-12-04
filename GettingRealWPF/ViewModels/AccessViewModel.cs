using GettingRealWPF.Models.Enumerations;
using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GettingRealWPF.ViewModels
{
    public class AccessViewModel
    {
        BookingRepository br = new BookingRepository();
        ItemRepository ir = new ItemRepository();
        public Choice Choice { get; set; }

        public User FetchCredentials(string name, string phoneNumber, Choice choice)
        {
            User fetchedUser = new User(name, phoneNumber);

            // check for privis
            if (fetchedUser.Name == "Jonas" && fetchedUser.PhoneNumber == "haha hemmelig")
            {
                fetchedUser.IsAdmin = true;
            }
            return fetchedUser;
        }

        public void testMethodForSavingABooking()
        {
            List<Item> items = ir.GetAll();
            //items.Add(new Item(0, "Smukke Shelter", ItemType.Shelter, Status.Available));
            //items.Add(new Item(1, "Lange Kano", ItemType.Canoe, Status.Available));


            //Shelter i = new Shelter(27, "Shelter", Models.Enumerations.Status.Unavailable);
            //User u = new User(Name, PhoneNumber, false);
            //Booking b = new Booking(0, items, DateTime.Today, DateTime.Today, u);

            //br.Save(b);

            //Debug.WriteLine(br.GetAll().ToString());
        }
    }
}