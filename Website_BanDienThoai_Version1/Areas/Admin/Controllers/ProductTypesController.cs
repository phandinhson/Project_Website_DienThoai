using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website_BanDienThoai_Version1.Models;
namespace Website_BanDienThoai_Version1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTypesController : Controller
    {
        private readonly DataBaseWedDienThoaiContext _db;
        public ProductTypesController(DataBaseWedDienThoaiContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Product.ToList());
        }
    }
}