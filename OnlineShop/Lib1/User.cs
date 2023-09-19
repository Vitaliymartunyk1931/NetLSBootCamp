using System;

namespace Lib1
{
    public class User
    {
        public int UserId { get; set; }
        protected string UserName { get; set; }
    }

    public class Customer : User
    {
        public string CustomerName { get; set; }
    }
}