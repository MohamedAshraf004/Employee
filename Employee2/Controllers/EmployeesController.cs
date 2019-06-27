using Employee2.Models;
using Employee2.ViewModels;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace Employee2.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Employees
        [Authorize]
        public ActionResult Create()
        {
            var ViewModel = new EmployeeFormViewModel
            {
                Genders = _context.Genders.ToList(),
                BloodGroups = _context.BloodGroups.ToList()

            };
            return View(ViewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeFormViewModel viewModel)
        {


            //var gender = _context.Genders.Single(g => g.Id == viewModel.Gender);
            //var bloodGroup = _context.BloodGroups.Single(b => b.Id == viewModel.BloodGroup);
            if (!ModelState.IsValid)
            {
                viewModel.Genders = _context.Genders.ToList();
                viewModel.BloodGroups = _context.BloodGroups.ToList();
                return View("Create", viewModel);
            }
            var employee = new Employee
            {
                EmployeeUserId = User.Identity.GetUserId(),
                SurName = viewModel.SurName,
                FatherName = viewModel.FatherName,
                MotherName = viewModel.MotherName,
                Birthplace=viewModel.Birthplace,
                Birthdate = viewModel.GetDateTime(),
                GenderId = viewModel.Gender,
                BloodGroupId = viewModel.BloodGroup
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();
            return RedirectToAction("index", "Home");
        }
    }
}