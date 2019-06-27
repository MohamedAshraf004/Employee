using Employee2.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Employee2.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context =new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var UpComingEmployees = _context.Employees.Include(e => e.EmployeeUser)
              //  .Include(e => e.SurName)
                .Include(e => e.Gender)
                .Include(e => e.BloodGroup)
                .Where(e => e.Birthdate < DateTime.Now);

            return View(UpComingEmployees);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}