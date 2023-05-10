using System.ComponentModel.DataAnnotations;

namespace Interior_decorating_company_models
{
    public class Workcatalog
    {
        [Key]
        public int Workcatalog_Id { get; set; }
        public string Name { get; set; }
        public int Pricework { get; set; }
    }
}
