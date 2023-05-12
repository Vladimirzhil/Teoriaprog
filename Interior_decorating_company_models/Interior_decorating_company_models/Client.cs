using System.ComponentModel.DataAnnotations;

namespace Interior_decorating_company_models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string? Customername { get; set; }
        public string? Phonenumber { get; set; }
    }
}

 