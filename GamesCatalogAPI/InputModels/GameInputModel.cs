using System.ComponentModel.DataAnnotations;

namespace GamesCatalogAPI.InputModels
{
    public class GameInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "The game must have between 3 and 100 characters length.")]
        public string Name {get; set;}
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The producer must have between 1 and 100 characters length.")]
        public string Producer {get; set;}
        [Required]
        [Range(1,1000, ErrorMessage = "The price must range from 1 to 1000 BRL.")]
        public double Price {get; set;}
    }
}