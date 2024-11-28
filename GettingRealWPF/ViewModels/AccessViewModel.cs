using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealWPF.ViewModels
{
    public class AccessViewModel
    {
        public static string Name { get; set; }
        public static string PhoneNumber { get; set; }

        public void SaveCredentials(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}