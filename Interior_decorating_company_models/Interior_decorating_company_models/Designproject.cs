using System.ComponentModel.DataAnnotations;

namespace Interior_decorating_company_models
{
    public class Designproject
    {
        [Key]
        public int Design_project_Id { get; set; }
        public string Design_project_name { get; set; }
        public int Employee_id { get; set; }
    }
}
