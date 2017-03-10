
namespace GameStore.Models
{
    public class UserAccess
    {
        public static bool Admin { get; set; }

        public static string SetAccess()
        {
            if (Admin)
                return "Go to buyer";
            else
                return "Go to admin";
        }
    }
}