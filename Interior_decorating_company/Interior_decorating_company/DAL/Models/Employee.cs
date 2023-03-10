using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Employee
    {
        [Key]
        public int Employee_id { get; set; }
        public string Employees_last_name { get; set; }
        public int JobtitleId { get; set; }
        public Jobtitle? Jobtitle { get; set; }
        
    }
}
