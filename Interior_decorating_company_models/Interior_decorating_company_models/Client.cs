using System.ComponentModel.DataAnnotations;

namespace Interior_decorating_company_models
{
    public class Client
    {
        [Key]
        public int Client_Id { get; set; }
        public string? Customer_name { get; set; }
        public string? Phone_number { get; set; }
    }
}

