﻿namespace DAL
{
    public class OrderLine
    {
        public int Order_number { get; set; }
        public int Order_line_number { get; set; }
        public int Quantity { get; set; }
        public int Item_ID { get; set; }
        public Product? Product { get; set; }
        public Orderforobject? Orderforobject { get; set; }
    }
}
