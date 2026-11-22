namespace PawFect_Match.Models
{
    public class Admin : UserAccount
    {
        public Admin()
        {
            Role = UserRole.Admin;
        }
    }
}