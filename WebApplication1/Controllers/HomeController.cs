using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DAL.DB;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            NPMContext db = new NPMContext();

            IEnumerable<OrgInfo> orgs = db.OrgInfos;
            return View();
        }
    }
}
