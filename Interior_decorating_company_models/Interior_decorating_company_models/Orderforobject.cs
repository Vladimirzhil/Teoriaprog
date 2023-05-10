using System.ComponentModel.DataAnnotations;

namespace Interior_decorating_company_models
{
    public class Orderforobject
    {

        [Key]
        public int Order_number_Id { get; set; }
        public DateTime Order_date { get; set; }
        public int Client_Id { get; set; }
        public string? Address_of_the_object { get; set; }
        public DateTime Execution_date { get; set; }
        public string? Contract_number { get; set; }
        public int Masteremployee_Id { get; set; }
        public int Design_Id { get; set; }
    }
}
