using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioMutant.API.Models
{
    public class Address
    {
        public Address() { }

        public Address(int addressId, string street, string suite, string city, string zipcode, int userId)
        {
            this.AddressId = addressId;
            this.Street = street;
            this.Suite = suite;
            this.City = city;
            this.Zipcode = zipcode;
            this.UserId = userId;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
