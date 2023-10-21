using Service.Service;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom_12.Controllers
{
    class ProductController
    {
        private readonly IProductService _productService;

        public ProductController()
        {
            _productService = new ProductService(); 
        }

        public Product[] GetAll()
        {
            var result = _productService.GetAll();
            foreach (var item in result) 
            {
                string data = $"Name {item.Name}, Price: {item.Price}, Category: {item.Category.Name}";
                Console.WriteLine(data);
            }
        }

        public void GetCount() 
        {
            int count = _productService.GetCount();
            Console.WriteLine(count);
        }
        public void SearByName() 
        {
            Console.WriteLine("Add product search text: ");
            string searchText = Console.ReadLine();
            var result = _productService.Search(searchText);
            foreach ( var item in result ) 
            {
                string data = $"Name: {item.Name}, Price: {item.Price}, Category: {item.Category.Name}";
                Console.WriteLine(data);
            
            
            }


        }

        public Product[] Search(string searchText)
        {
            throw new NotImplementedException();
        }

        int IProductService.GetCount()
        {
            throw new NotImplementedException();
        }

        public void GetAll() 
        {
            var result = _productService.Search();
            foreach (var item in result) 
            {
                string data = $"Name: {item.Name}, Price: {item.Price}, Category: {item.Category.Name}";
                Console.WriteLine(data);


            }
        
        }

        public void GetAveragePrice() 
        {
            var avgPrice = _productService.GetAveragePrice();
            Console.WriteLine(avgPrice);


        }

        public void OrderByDate() 
        {
            var result = _productService.OrderByDate();
            foreach (var item in result)
            {
                string data = $"Name: {item.Name}, Price: {item.Price}, Date: {item.CreateDate.Tostring("dd-MM-YYYY")}, Category: {item.Category.Name}";
                Console.WriteLine(data);


            }


        }

        public void GertAllByCategoryName()
        {
            Console.WriteLine("Add product category name: ");
            string category = Console.ReadLine();
            var result = _productService.GertAllByCategoryName();
            foreach (var item in result)
            {
                string data = $"Name: {item.Name}, Price: {item.Price}, Date: {item.CreateDate.Tostring("dd-MM-YYYY")}, Category: {item.Category.Name}";
                Console.WriteLine(data);


            }


        }

        public void GetAllByCategoryId() 
        {
            Console.WriteLine("Please add product category id");
            int categoryId = int.Parse(Console.ReadLine());

            var result = _productService.GetAllByCategoryId(categoryId);
            foreach (var item in result) 
            {
                string data = $"Name: {item.Name}, Price: {item.Price}, Date: {item.CreateDate.Tostring("dd-MM-YYYY")}, Category: {item.Category.Name}";
                Console.WriteLine(data);
            }

           


        }

    }
}
