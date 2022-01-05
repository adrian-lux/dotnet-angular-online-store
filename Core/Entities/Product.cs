using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
  

        public Product(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PictureUrl { get; set; }

        //relationship
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }

        //relationship 
        public ProductBrand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }

    }
}