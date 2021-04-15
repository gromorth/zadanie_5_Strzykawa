using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContosoCrafts.WebSite.Models
{
    public class Product
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Maker { get; set; }
        
        [JsonPropertyName("img")]
        public string Image { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);

 
    }
}