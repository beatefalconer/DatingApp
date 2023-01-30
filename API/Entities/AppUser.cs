using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Extensions;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash {get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateOnly DateOfBirth { get; set;}
        public string KnownAs {get; set;}
        public DateTime Created {get; set;} = DateTime.UtcNow;
        public DateTime LastActive {get; set;} = DateTime.UtcNow;
        public string Gender {get; set;}
        public string LookingFor {get; set;}
        public string Interestes {get; set;}
        public string City {get; set;}
        public string Country {get; set;}
        public List<Photo> Photos {get; set;} = new();
        //equivalent to
        //public List<Photo> Photos {get; set;} = new List<Photo>();

        public int GetAge() {
            return DateOfBirth.CalculateAge();
        }
    }
}