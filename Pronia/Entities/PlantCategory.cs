namespace Pronia.Entities
{
    public class PlantCategory:BaseEntity
    {
        public Plant Plant { get; set; }
        public Category Category { get; set; }

        public  int ? PlantId { get; set; }
        public int ? CategoryId { get; set; }

    }
}
