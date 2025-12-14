using System.Collections.Generic;

namespace OOPinCsharp
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Order> orders;

        public Customer()
        {
            orders = new List<Order>();
        }

        public Customer(int id, string name, string email) //ctor for shortcut
        : this()
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }

        public Customer(string name, string email) //ctor for shortcut
        : this()
        {

            this.Name = name;
            this.Email = email;
        }

    }
}
