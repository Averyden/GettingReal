using GettingRealWPF.Models.Enumerations;

namespace GettingRealWPF.Models.Classes
{
    public class User
    {

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Permission PermissionLvl { get; set; }

        public User(string name, string phoneNumber, Permission permissionLvl)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            PermissionLvl = permissionLvl;
        }
    }
}
