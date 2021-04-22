using System;

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace AddressBookApp.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Person> People { get; set; }

    }
}
