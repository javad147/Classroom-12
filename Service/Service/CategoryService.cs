using Domain.Data;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
       

    public class CategoryService : ICategoryService
    {
        private readonly CategoryService _context;

        public CategoryService()
        {
            _context = new AddDbContext();
        }
        public Category[] GetAll()
        {
            return _context.Categories();   
        }
    }
}
