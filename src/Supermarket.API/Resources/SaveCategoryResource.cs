using System.ComponentModel.DataAnnotations;

namespace Supermarket.API.Resources
{
    public record SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string? Name { get; init; }
    }
}