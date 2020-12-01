using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Product_Manager_NguyenTrungAnh.Models;
using Product_Manager_NguyenTrungAnh.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Product_Manager_NguyenTrungAnh.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            this.ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

    }
}

