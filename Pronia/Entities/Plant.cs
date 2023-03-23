using System.ComponentModel.DataAnnotations.Schema;

namespace Pronia.Entities
{
    public class Plant : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName="decimal(6,2)")]
        public decimal Price { get; set; }

        public string SKU { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal? DiscountPrice { get; set; }

        public PlantDeliveryInformation PlantDeliveryInformation { get; set; }

        
        public List<PlantImage>PlantImages { get; set;}
        public List<PlantCategory> PlantCategories { get; set; }

        public List<PlantTag> PlantTags { get; set; }

        public Plant()
        {
            PlantCategories= new List<PlantCategory>();
        }
    }
}
