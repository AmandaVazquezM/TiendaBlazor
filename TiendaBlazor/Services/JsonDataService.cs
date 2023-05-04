using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using TiendaBlazor.Models;

namespace TiendaBlazor.Services
{
    public class JsonDataService
    {

        public JsonDataService()
        {
            
        }

        public List<Product> GetProducts()
        {
            var products = new List<Product>
    {
        new Product { Id = 1, Name = "Producto 1", Price = 100, Description = "Descripción del producto 1", CategoryId = 1, Image="imgs/img2.rtve.jpg" },
        new Product { Id = 2, Name = "Producto 2", Price = 200, Description = "Descripción del producto 2", CategoryId = 1, Image="imgs/img2.rtve.jpg" },
        new Product { Id = 3, Name = "Producto 3", Price = 300, Description = "Descripción del producto 3", CategoryId = 2, Image="imgs/img2.rtve.jpg" },
        new Product { Id = 4, Name = "Producto 4", Price = 400, Description = "Descripción del producto 4", CategoryId = 2, Image="imgs/img2.rtve.jpg" },
        new Product { Id = 5, Name = "Producto 5", Price = 500, Description = "Descripción del producto 5", CategoryId = 3, Image="imgs/img2.rtve.jpg" },
        new Product { Id = 6, Name = "Producto 6", Price = 600, Description = "Descripción del producto 6", CategoryId = 3, Image="imgs/img2.rtve.jpg" },
        new Product { Id = 7, Name = "Producto 7", Price = 400, Description = "Descripción del producto 7", CategoryId = 2, Image="imgs/img2.rtve.jpg" },
        new Product { Id = 8, Name = "Producto 8", Price = 500, Description = "Descripción del producto 8", CategoryId = 3, Image="imgs/img2.rtve.jpg" },
        new Product { Id = 9, Name = "Producto 9", Price = 600, Description = "Descripción del producto 9", CategoryId = 3, Image="imgs/img2.rtve.jpg" },
    };

            return products;
        }

        public List<Category> GetCategories()
        {
            var category = new List<Category>
           {
                new Category { Id = 1, Name = "Category 1" },
                new Category { Id = 2, Name = "Category 2" },
                new Category { Id = 3, Name = "Category 3" }
           };
            return category;
        }

        public List<Customer> GetCustomers()
        {
            var customer = new List<Customer>
            {
                 new Customer { Id = 1, Name = "Customer 1", Email = "customer1@example.com" },
                 new Customer { Id = 2, Name = "Customer 2", Email = "customer2@example.com" }
            };
            return customer;
           
        }

    }
}
