using System;

namespace Lib1
{
    public abstract partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
    }

    public partial class Customer : User
    {
        public string CustomerName { get; set; }
    }

    public partial class PremiumUser : User
    {
        public decimal PremiumDiscount { get; set; }

        public PremiumUser()
        {
            PremiumDiscount = 0.15m;
        }
    }
}