using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KhMedium.Data;
using KhMedium.Entities;

namespace KhMedium.Areas.Admin.Controllers
{
    public class TagsController : Controller
    {
        private readonly UnitOfWork _context = new UnitOfWork(new KhMediumEntities());

        // GET: Admin/Tags
        public ActionResult Index()
        {
            var tags = _context.Tags.GetAll();
            return View(tags);
        }
    }
}