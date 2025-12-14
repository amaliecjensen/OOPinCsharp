using System.Collections.Generic;

namespace OOPinCsharp
{
    public class Customer
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        public readonly List<Order> orders = new List<Order>();

        public Customer(int id, string name, string email) //ctor for shortcut

        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }

        public Customer(string name, string email) //ctor for shortcut

        {
            this.Name = name;
            this.Email = email;
        }

    }
}

