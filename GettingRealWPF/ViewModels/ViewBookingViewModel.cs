using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealWPF.ViewModels
{

    public class ViewBookingViewModel
    {
        private DeleteBookingCmd _delCmd { get; set; }

        public DeleteBookingCmd DeleteCmd
        {
            get
            {
                if (_delCmd == null)
                {
                    _delCmd = new DeleteBookingCmd();
                }
                return _delCmd;
            }
            set
            {
                _delCmd = value;
            }
        }



        public Booking SelectedBooking { get; set; }

        public ViewBookingViewModel(Booking booking)
        {
            SelectedBooking = booking;
        }
    }
}
