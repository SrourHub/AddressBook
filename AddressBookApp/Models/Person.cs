using System;
using System.ComponentModel.DataAnnotations;

namespace AddressBookApp.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Contact Details")]
        public string ContactDetails { get; set; }

        public int OrganizationId { get; set; }

        public Organization Organization { get; set; }


    }
}


