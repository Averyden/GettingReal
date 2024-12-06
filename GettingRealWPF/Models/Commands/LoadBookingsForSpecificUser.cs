using GettingRealWPF.ViewModels;
using System.Diagnostics;
using System.Windows.Input;

namespace GettingRealWPF.Models.Commands
{
    public class LoadBookingsForSpecificUser : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            // THIS IS ALWAYS  TRUE, ITS A COMMAND THAT RUNS WHEN USER LOGS IN AND OPTION WAS SEE BOOKINGS
            return true;
        }

        public void Execute(object? parameter) // We are assuming that the average user of this would see "name" then input their full name, making our search easier.
            // A further iteration of this could potentially be that like, we search for their phone number interally as well, but never display it.
        {
            // We check the bookingRepo, if no bookings, tell the user they have none, if they do... then display their bookings in the form of button elements duhh.
           if (parameter is string)
            {
                Debug.WriteLine("THIS BITCH WORKS BETTER THAN EXPECTED");
            }
        }
    }
}
