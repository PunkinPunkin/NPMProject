using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using DAL.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using System.Linq.Expressions;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            NPMContext db = new NPMContext();
            var paintings = db.NpmPainting.AsQueryable();
            string subject = "山水";

            if (subject != string.Empty)
            {
                paintings = paintings.Where(x => x.NpmPSubject.Any(y => y.Subject1 == subject));
            }

            paintings = OrderByCol(paintings, o => o.ItemNo).AsQueryable();


            return View(paintings);
        }


        public IEnumerable<TSource> OrderByCol<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> order)
        {
            return source.OrderBy(order);
        }
    }

}
