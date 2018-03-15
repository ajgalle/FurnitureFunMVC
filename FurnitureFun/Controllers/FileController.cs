using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FurnitureFun.Data;

namespace FurnitureFun.Controllers
{
    public class FileController : Controller
    {
        private Context db = new Context();
        // GET: File
        public ActionResult Index(int id)
        {
            var fileToRetrieve = db.Files.Find(id);
            return File(fileToRetrieve.Content, fileToRetrieve.ContentType);

            
        }
    }
}
