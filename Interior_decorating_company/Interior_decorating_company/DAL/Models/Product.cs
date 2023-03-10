using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Product
    {
        [Key]
        public int Item_Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public LinkedList<OrderLine> OredrLines { get; set; } = new();
    }
}
