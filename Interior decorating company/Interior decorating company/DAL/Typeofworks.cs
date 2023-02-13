namespace DAL
{
    public class Typeofwork
    {
        public int Order_number { get; set; }
        public int Job_line_number { get; set; }
        public string? Value { get; set; }
        public int Job_id { get; set; }
        public Workcatalog? Workcatalog { get; set; }
        public Orderforobject? Orderforobject { get; set; }
    }
}
