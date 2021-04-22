using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AddressBookApp.Models
{
    public class Organization
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Contact Details")]
        public string ContactDetails { get; set; }

        public ICollection<Person> People { get; set; }
    }
}
