using System.ComponentModel.DataAnnotations;

namespace Supermarket.API.Resources
{
    public record SaveProductResource
    {
        [Required]
        [MaxLength(50)]
        public string? Name { get; init; }

        [Required]
        [Range(0, 100)]
        public short QuantityInPackage { get; init; }

        [Required]
        [Range(1, 5)]
        public int UnitOfMeasurement { get; init; }

        [Required]
        public int CategoryId { get; init; }
    }
}