using EComm.Abstractions;
using EComm.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EComm.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepository _repository;

        public ProductController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("")]
        public async Task<IEnumerable<Product>> Get()
        {
            var products = await _repository.GetAllProducts(includeSupplier: true);

            return products;
        }

        [HttpPatch("")]
        public async Task<IActionResult> Patch(Product product)
        {
            var existingProduct = _repository.AllProducts()
                .SingleOrDefault(p => p.Id == product.Id);

            if (existingProduct == null) return NotFound();

            if (product.ProductName != null) 
                existingProduct.ProductName = product.ProductName;

            existingProduct.UnitPrice = product.UnitPrice;

            //_repository.Attach(product);      

            await _repository.Save();

            return NoContent();
        }

        [HttpPatch("updateprice/{id}")]
        public async Task<IActionResult> UpdatePrice(int id, PriceInfo price)
        {
            if (price.Price > 100) {
                return BadRequest(new { Error = "BAD THINGS!!!" });
            }

            var existingProduct = _repository.AllProducts()
                .SingleOrDefault(p => p.Id == id);

            if (existingProduct == null) return NotFound();

            existingProduct.UnitPrice = price.Price;      

            await _repository.Save();

            return NoContent();
        }
    }

    public class PriceInfo
    {
        public decimal Price { get; set; }
    }
}
