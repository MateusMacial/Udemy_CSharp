namespace Array
{
    class Room
    {
        public string Name { get; set; }
        public string Email { get; set; }
        
        public Room(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
