using GettingRealWPF.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealWPF.ViewModels
{
    public class AccessViewModel
    {
        public static string Name {  get; set; }
        public static string PhoneNumber { get; set; }
        public static Choice Choice { get; set; }

        public void SaveCredentials(string name, string phoneNumber, Choice choice)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Choice = choice;
        }
    }
}
