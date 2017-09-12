using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;
        public ProductController(IProductRepository repository)
        {
            _productRepository = repository;
        }

        public ViewResult List() => View(_productRepository.Products);
    }
}
