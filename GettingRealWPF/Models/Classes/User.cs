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

        public User(string name, string phoneNumber) : this(name, phoneNumber, false) // False by default unless wacky check is called
        {

        }

        public override string ToString()
        {
            if (IsAdmin)
            {
                return $"{Name} ({PhoneNumber}), [ADMINISTRATOR]";
            }
            else
            {
                return $"{Name} ({PhoneNumber})";
            }
        }
    }
}
