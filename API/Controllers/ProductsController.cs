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

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        public StoreContext context { get; }
        public ProductsController(StoreContext context)
        {
            this.context = context;

        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts(){
            var products = await this.context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id){
            var product = await this.context.Products.FindAsync(id);
            return Ok(product);
        }
    }
}