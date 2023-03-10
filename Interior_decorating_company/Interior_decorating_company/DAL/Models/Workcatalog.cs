using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Workcatalog
    {
        [Key]
        public int WorkcatalogId { get; set; }
        public string Name { get; set; }
        public int Pricework { get; set; }
        public LinkedList<Typeofwork> Typeofworks { get; set; } = new();
    }
}
