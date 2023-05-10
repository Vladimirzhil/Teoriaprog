using System.ComponentModel.DataAnnotations;

namespace Interior_decorating_company_models
{
    public class Jobtitle
    {
        [Key]
        public int Job_Id { get; set; }
        public string Job_Title { get; set; }
    }
}
