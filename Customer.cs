namespace OOPinCsharp
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

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
