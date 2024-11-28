using GettingRealWPF.Models.Enumerations;

namespace GettingRealWPF.Models.Classes
{
    public class User
    {

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAdmin { get; set; }

        public User(string name, string phoneNumber, bool isAdmin)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            IsAdmin = isAdmin;
        }
    }
}
