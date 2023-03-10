using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class OrderLine
    {
        [Key]
        public int OrderLine_ID { get; set; }
        public int Order_number { get; set; }
        public int Order_line_number { get; set; }
        public int Quantity { get; set; }
        public int Item_ID { get; set; }
        public Product? Product { get; set; }
        public Orderforobject? Orderforobject { get; set; }
    }
}
