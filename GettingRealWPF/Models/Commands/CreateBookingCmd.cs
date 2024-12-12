using GettingRealWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GettingRealWPF.Models.Commands
{
    public class CreateBookingCmd : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            // TODO
            // Only enable the button if valid booking parameters
            return true;
        }

        public void Execute(object? parameter)
        {
            // Check if the parameter is type of CreateBookingViewModel
            if (parameter is CreateBookingViewModel vm)
            {
                vm.CreateBooking();
            }
        }
    }
}
