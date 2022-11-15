using Lab3.Classes;
using Lab3.Represitories;
using System.Reflection.Metadata;

namespace Lab3.Service
{
    public class FillService : IFillService
    {
        private IBaseRepository<Workcatalog> Workcatalogs { get; set; }
        private IBaseRepository<Typeofwork> Typeofworks { get; set; }
        

        public void Fill()
        {
            var rand = new Random();
            var workcatalogId = Guid.NewGuid();
            

            Workcatalogs.Create(new Workcatalog
            {
                Id = workcatalogId,
                Name = String.Format($"Work{rand.Next()}"),
                price = String.Format($"{rand.Next()}")
            });
            var workcatalog = Workcatalogs.Get(workcatalogId);

            var typeofwork = Typeofworks.Get(workcatalogId);

            Typeofworks.Create(new Typeofwork
            {
                Order_number = String.Format($"{rand.Next()}"),
                Job_line_number = String.Format($"{rand.Next()}"),
                Value = String.Format($"{rand.Next()}"),
                WorkcatalogId= workcatalog.Id,
            });
        }
    }
}
