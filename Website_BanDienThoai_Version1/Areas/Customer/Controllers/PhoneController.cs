using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Website_BanDienThoai_Version1.Models;
namespace Website_BanDienThoai_Version1.Controllers
{
    [Area("Customer")]
    public class PhoneController : Controller
    {
        
        public IActionResult Index()
        {
            
            return View();
        }
    }
}