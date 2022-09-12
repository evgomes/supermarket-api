using Supermarket.API.Domain.Models.Abstract;

namespace Supermarket.API.Domain.Models
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public short QuantityInPackage { get; set; }
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}