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