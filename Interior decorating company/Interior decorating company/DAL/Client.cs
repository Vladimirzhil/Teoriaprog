using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Client
    {
        [Key]
        public int Client_ID { get; set; }
        public string? Customer_name { get; set; }
        public string? Phone_number { get; set; }
    }
}

