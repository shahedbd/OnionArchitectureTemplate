using Core.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Repository.Data
{
    public class SeedData
    {
        public IEnumerable<Categories> GetCategoriesList()
        {
            return new List<Categories>
            {
                new Categories { Name = "Fruits", Description = "Fruits Item"},
                new Categories { Name = "Dairy Products", Description = "Dairy Products"},
                new Categories { Name = "Beverages", Description = "Soft drinks, coffees, teas, etc"},
                new Categories { Name = "Freezer", Description = "Freezer"},
                new Categories { Name = "Meat & Fish", Description = "Meat & Fish"},
                new Categories { Name = "Vegetables", Description = "Vegetables"},
                 new Categories { Name = "Beauty and Cosmetic", Description = "Beauty and Cosmetic"},

                new Categories { Name = "IT", Description = "IT"},
                new Categories { Name = "Electronics", Description = "Electronics"},
                new Categories { Name = "Steels", Description = "Coated Steel Sheet"},
                new Categories { Name = "Common", Description = "For common all items"},
            };
        }
        public IEnumerable<Branch> GetBranchList()
        {
            return new List<Branch>
            {
                new Branch { Name = "Main Branch", ContactPerson = "Admin", PhoneNumber = "123456789", Address = "Berlin, Germany", ShortDescription = "TBD" },

                new Branch { Name = "Branch One", ContactPerson = "Person 01", PhoneNumber = "123456789", Address = "Hamburg, Germany", ShortDescription = "TBD" },
                new Branch { Name = "Branch Two", ContactPerson = "Person 02", PhoneNumber = "123456789", Address = "Munich, Germany", ShortDescription = "TBD" },
                new Branch { Name = "Branch Three", ContactPerson = "Person 03", PhoneNumber = "123456789", Address = "Frankfurt, Germany", ShortDescription = "TBD" },
                new Branch { Name = "Branch Four", ContactPerson = "Person 04", PhoneNumber = "123456789", Address = "Leipzig, Germany", ShortDescription = "TBD" },
                new Branch { Name = "Branch Five", ContactPerson = "Person 05", PhoneNumber = "123456789", Address = "Parish, French", ShortDescription = "TBD" },
            };
        }
    }
}
