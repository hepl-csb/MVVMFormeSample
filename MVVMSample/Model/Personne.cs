using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSample.Model
{
    public class Personne
    {
        public Personne(string firstName, string lastName, string email, string phone, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            BirthDate = birthDate;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
