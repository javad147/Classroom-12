using Domain.Data;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class ProductService : IProductService
    {
        private readonly AddDbContext _context;

        public ProductService()
        {
            _context = new AddDbContext();
        }

        public Product[] GetAll()
        {
            return _context.Products();
        }

        public decimal GetAveragePrice()
        {
            Product[] products = _context.Products();
            decimal sumOfPrice = products.Sum(m => m.Price);
            return sumOfPrice/productCount;
        }

        public int GetCount()
        {
            var products = _context.Products();
            return products.Length;
        }

        public Product[] OrderByDate()
        {
            return _context.Products().OrderByDescending(m=>m.CreateDate).ToArray();
        }

        public Product[] Search(string searchText)
        {
           
            
            return _context.Products().Where(m=>m.Name.Trim().ToLower().Contains(searchText.Trim().ToLower())).ToArray();
        }

        public Product[] GetAllCategoryName(string categoryName)
        {
            return _context.Products().Where(m=>m.Category.Name == categoryName).ToArray();

        }

        public Product[] GetAllByCategoryId(int id)
        {
            return _context.Products().Where(m => m.Category.Id == id).ToArray();

      
        }
    }
}
