using AutoMapper;
using GlobalManagementSystem.Web.Constants;
using GlobalManagementSystem.Web.Data;
using GlobalManagementSystem.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GlobalManagementSystem.Web.Controllers
{
    public class EmployeesController : Controller
    {

        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;

        public EmployeesController(UserManager<Employee> userManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.mapper = mapper;

        }
        // GET: EmplyeesController
        public async Task<IActionResult> Index()
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var model = mapper.Map<List<EmployeeVM>>(employees);
            return View(model);
        }

        // GET: EmplyeesController/Details/5
        public async Task<IActionResult> Details(string id)
        {
            var employees = await userManager.FindByIdAsync(id);
            var model = mapper.Map<EmployeeVM>(employees);
            return View(model);
        }

        // POST: EmplyeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmplyeesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmplyeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmplyeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmplyeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
