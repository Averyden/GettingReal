using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Repositories;
using GettingRealWPF.ViewModels;
using GettingRealWPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GettingRealWPF.Models.Commands
{
    public class DeleteBookingCmd : ICommand
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
            if (parameter is Booking book)
            {
                BookingRepository br = new BookingRepository();
                br.Delete(book);

                var activeUser = book.ConnectedUser;
                if (activeUser != null)
                {
                    ListBookingsWindow listBookingsWindow = new ListBookingsWindow(activeUser);
                    listBookingsWindow.Show();
                }
            }
           
        }
    }
}
