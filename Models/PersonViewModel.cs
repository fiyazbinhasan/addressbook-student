using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookMVC.Models
{
    public class PersonViewModel
    {
        [DisplayName("First Name")]
        [MaxLength(10)]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
