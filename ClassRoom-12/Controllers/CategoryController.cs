using Service.Service.Interfaces;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom_12.Controllers
{
    internal class CategoryController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController()
        {
            _categoryService = new CategoryService();
        }

        public void GetAll() 
        {
            var categories = _categoryService.GetAll();
   
            foreach (var item in categories)
            {
                string data = $"Name {item.Name}";
                Console.WriteLine(data);
            }

        }
    }
}
