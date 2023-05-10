using System.ComponentModel.DataAnnotations;

namespace Interior_decorating_company_models
{
    public class Employee
    {
        [Key]
        public int Employee_Id { get; set; }
        public string Employees_last_name { get; set; }
        public int Jobtitle_Id { get; set; }
    }
}
