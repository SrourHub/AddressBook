using System;
using System.Linq;

namespace AddressBookApp.Models
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();


            if (context.Organizations.Any())
            {
                return;   // DB has been seeded
            }

            var organizations = new Organization[]
            {
            new Organization() { Name = "Organization1", ContactDetails = "organization1@gmail.com" },
            new Organization() { Name = "Organization2", ContactDetails = "organization2@gmail.com" },
            new Organization() { Name = "Organization3", ContactDetails = "organization3@gmail.com" },
            new Organization() { Name = "Organization4", ContactDetails = "organization4@gmail.com" },

            };
            foreach (Organization o in organizations)
            {
                context.Organizations.Add(o);
            }
            context.SaveChanges();

            var people = new Person[]
            {
            new Person{Name="Person1",ContactDetails = "person1@gmail.com",OrganizationId = 1},
            new Person{Name="Person2",ContactDetails="person2@gmail.com",OrganizationId = 2},
            new Person{Name="Person3",ContactDetails = "person3@gmail.com",OrganizationId = 1},
            new Person{Name="Person4", ContactDetails="person4@gmail.com",OrganizationId = 3},
            new Person{Name="Person5",ContactDetails = "person5@gmail.com",OrganizationId = 4},
            new Person{Name="Person6",ContactDetails = "person6@gmail.com",OrganizationId = 2},
            new Person{Name="Person7",ContactDetails ="person7@gmail.com",OrganizationId = 1},
            new Person{Name="Person8",ContactDetails="person8@gmail.com",OrganizationId = 2}
            };
            foreach (Person p in people)
            {
                context.People.Add(p);
            }
            context.SaveChanges();



            
        }
    }
}
