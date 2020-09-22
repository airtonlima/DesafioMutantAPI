using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioMutant.API.Models
{
    public class Contact
    {
        public Contact() { }

        public Contact(string contactId, string phone, string website, int userId)
        {
            this.ContactId = contactId;
            this.Phone = phone;
            this.Website = website;
            this.UserId = userId;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ContactId { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
