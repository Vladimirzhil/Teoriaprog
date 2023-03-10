using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Orderforobject
    {

        [Key]
        public int Order_number { get; set; }
        public DateTime Order_date { get; set; }
        public int Client_ID { get; set; }
        public string? Address_of_the_object { get; set; }
        public DateTime Execution_date { get; set; }
        public int Contract_number { get; set; }
        public int Manageremployee_Id { get; set; }
        public int Masteremployee_Id { get; set; }
        public int Designeremployee_Id { get; set; }
        public int Design_ID { get; set; }
        public int line_of_work { get; set; }
        public int Order_line { get; set; }
        public string? Execution_Status { get; set; }
        // не работает из-за 3 ссылок 
        public Client? Client { get; set; }
        public Employee? Employee { get; set; }
        public Designproject? Designproject { get; set; }
        public LinkedList<OrderLine> OredrLines { get; set; } = new();
        public LinkedList<Typeofwork> Typeofworks { get; set; } = new();
    }
}
