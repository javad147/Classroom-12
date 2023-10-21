using Domain.Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data
{
    public class AddDbContext
    {
        public Category[] Categories()
        {
            return new Category[]
            {
                new Category() {Id = 1, Name = "Phone" },
                new Category() {Id = 2, Name = "TV"},
                new Category() {Id = 3, Name = "Console"},
                new Category() {Id = 4, Name = "Computer"},
            };
        
        
        
        }
        public Product[] Products()
        {
            return new Product[]
            {
                new Product { Id = 1, Name = "Iphone 15", Price = 3500, CreateDate = new DateTime(2023,05,25), Category = Categories().FirstOrDefault(m=>m.Id == 1) },
                new Product { Id = 2, Name = "Iphone 14", Price = 3000, CreateDate = new DateTime(2023,05,17), Category = Categories().FirstOrDefault(m=>m.Id == 1) },
                new Product { Id = 3, Name = "Samsung 7V", Price = 2000, CreateDate = new DateTime(2023,06,25), Category = Categories().FirstOrDefault(m=>m.Id == 2) },
                new Product { Id = 4, Name = "Sony PS5", Price = 500, CreateDate = new DateTime(2023,05,11), Category = Categories().FirstOrDefault(m=>m.Id == 3) }
            };

        }
    }
}
