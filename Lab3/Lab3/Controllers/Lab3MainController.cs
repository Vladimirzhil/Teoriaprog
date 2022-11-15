using Lab3.Classes;
using Lab3.Represitories;
using Lab3.Service;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace Lab3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        private IFillService FillService { get; set; }
        private IBaseRepository<Typeofwork> Typeofworks { get; set; }

        public MainController(IFillService fillService, IBaseRepository<Typeofwork> typeofwork)
        {
            FillService = fillService;
            Typeofworks = typeofwork;
        }

        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(Typeofworks.GetAll());
        }

        [HttpPost]
        public JsonResult Post()
        {
            FillService.Fill();
            return new JsonResult("Work was successfully done");
        }

        [HttpPut]
        public JsonResult Put(Typeofwork doc)
        {
            bool success = true;
            var typeofwork = Typeofworks.Get(doc.Id);
            try
            {
                if (typeofwork != null)
                {
                    typeofwork = Typeofworks.Update(doc);
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception)
            {
                success = false;
            }

            return success ? new JsonResult($"Update successful {typeofwork.Id}") : new JsonResult("Update was not successful");
        }

        [HttpDelete]
        public JsonResult Delete(Guid id)
        {
            bool success = true;
            var typeofwork = Typeofworks.Get(id);

            try
            {
                if (typeofwork != null)
                {
                    Typeofworks.Delete(typeofwork.Id);
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception)
            {
                success = false;
            }

            return success ? new JsonResult("Delete successful") : new JsonResult("Delete was not successful");
        }
    }
}