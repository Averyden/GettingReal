using GettingRealWPF.Models.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealWPF.ViewModels
{

    public class ViewBookingViewModel
    {        
        public Booking Booking { get; set; }

        public ViewBookingViewModel(Booking booking)
        {
            Booking = booking;
        }
    }
}
