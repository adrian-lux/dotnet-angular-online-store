using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product
    {
  

        public Product(string name)
        {
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}