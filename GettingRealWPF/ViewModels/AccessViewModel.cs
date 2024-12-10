using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Enumerations;
using GettingRealWPF.Models.Repositories;
using System.ComponentModel;

namespace GettingRealWPF.ViewModels
{
    public class AccessViewModel : INotifyPropertyChanged
    {
        BookingRepository br = new BookingRepository();
        ItemRepository ir = new ItemRepository();
        public Choice Choice { get; set; }

        private string _name;
        private string _phone;
        private bool _isContinueButtonEnabled;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                    UpdateButtonState();
                }
            }
        }

        public string Phone
        {
            get { return _phone; }
            set
            {
                if (_phone != value)
                {
                    _phone = value;
                    OnPropertyChanged(nameof(Phone));
                    UpdateButtonState();
                }
            }
        }

        private void UpdateButtonState()
        {
            IsContinueButtonEnabled = !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Phone);
        }

        public bool IsContinueButtonEnabled
        {
            get { return _isContinueButtonEnabled; }
            private set
            {
                if (_isContinueButtonEnabled != value)
                {
                    _isContinueButtonEnabled = value;
                    OnPropertyChanged(nameof(IsContinueButtonEnabled));
                }
            }
        }

        public User FetchCredentials(string name, string phoneNumber, Choice choice)
        {
            User fetchedUser = new User(name, phoneNumber, false); //TODO: implement a check for usernames.

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


        protected void OnPropertyChanged(string propertyName)

        {

            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;

            if (propertyChanged != null)

            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));

            }

        }
    }
}