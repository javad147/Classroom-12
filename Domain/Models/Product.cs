using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public Category Category { get; set; }
    }
}
