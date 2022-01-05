using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Core.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        public IProductRepository Repo { get; }
      
        public ProductsController(IProductRepository repo)
        {
            this.Repo = repo;


        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts(){
            var products = await this.Repo.GetProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id){
            var product = await this.Repo.GetProductByIdAsync(id);
            return Ok(product);
        }
    }
}