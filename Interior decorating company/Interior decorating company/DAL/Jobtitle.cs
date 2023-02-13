using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Jobtitle
    {
        [Key]
        public int Job_ID { get; set; }
        public string Job_Title { get; set; }
        public LinkedList<Employee> Employees { get; set; } = new();
    }
}
