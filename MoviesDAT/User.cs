using System.ComponentModel.DataAnnotations;


namespace MoviesDAT
{
    public abstract class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Address { get; set; }
        [Required]
        public Role Role { get; set; }

        protected User(int userId, string firstName, string lastName, string email, string address, Role role)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            Role = role;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

    }
}
