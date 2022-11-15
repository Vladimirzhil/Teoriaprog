using Lab3.Classes;
using Lab3.DataBase;
using Lab3.Represitories;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;




namespace Lab3.Represitories
{
    public class BaseRepository<TDbModel> : IBaseRepository<TDbModel> where TDbModel : BaseModel
    {
        private ApplicationContext Context { get; set; }
        public BaseRepository(ApplicationContext context)
        {
            Context = context;
        }

        public TDbModel Create(TDbModel model)
        {
            Context.Set<TDbModel>().Add(model);
            Context.SaveChanges();
            return model;
        }

        public void Delete(Guid id)
        {
            var toDelete = Context.Set<TDbModel>().FirstOrDefault(m => m.Id == id);
            Context.Set<TDbModel>().Remove(toDelete);
            Context.SaveChanges();
        }

        public List<TDbModel> GetAll()
        {
            return Context.Set<TDbModel>().ToList();
        }

        public TDbModel Update(TDbModel model)
        {
            var toUpdate = Context.Set<TDbModel>().FirstOrDefault(m => m.Id == model.Id);
            if (toUpdate != null)
            {
                toUpdate = model;
            }
            Context.Update(toUpdate);
            Context.SaveChanges();
            return toUpdate;
        }

        public TDbModel Get(Guid id)
        {
            return Context.Set<TDbModel>().FirstOrDefault(m => m.Id == id);
        }
    }
}