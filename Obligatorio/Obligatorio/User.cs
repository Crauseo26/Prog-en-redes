using System;


namespace Obligatorio
{
    public class User
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private string BirthDate { get; set; }
        private WorkProfile WorkProfile { get; set; }

        public User(string firstName, string lastName, string email, string password, string birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.BirthDate = birthDate;
            this.WorkProfile = new WorkProfile(this);

        }
        
    }
}