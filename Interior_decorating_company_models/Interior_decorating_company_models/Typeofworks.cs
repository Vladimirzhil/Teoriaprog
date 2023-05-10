using System.ComponentModel.DataAnnotations;

namespace Interior_decorating_company_models
{
    public class Typeofwork
    {
        [Key]
        public int Typeofwork_Id { get; set; }
        public int Order_number_Id { get; set; }
        public string? Value { get; set; }
        public int Job_Id { get; set; } 
    }
}
