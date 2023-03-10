using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Designproject
    {
        [Key]
        public int Design_project_ID { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
