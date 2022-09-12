using Supermarket.API.Domain.Models.Abstract;
using System.Collections.Generic;

namespace Supermarket.API.Domain.Models
{
    public class Category: BaseEntity
    {
        public string Name { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}