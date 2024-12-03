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


        public static string Name { get; set; }
        public static string PhoneNumber { get; set; }
        public static Choice Choice { get; set; }

        public void SaveCredentials(string name, string phoneNumber, Choice choice)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Choice = choice;
        }

        public void testMethodForSavingABooking()
        {
            List<Item> items = new List<Item>();
            items.Add(new Shelter(0, "Smukke Shelter", Status.Udlejet));
            items.Add(new Canoe(0, "Lange Kano", Status.Udlejet));

            //Shelter i = new Shelter(27, "Shelter", Models.Enumerations.Status.Udlejet);
            User u = new User(Name, PhoneNumber, false);
            Booking b = new Booking(4, items, DateTime.Today, DateTime.Today, u);

            br.Save(b);

            //Debug.WriteLine(br.GetAll().ToString());
        }
    }
}