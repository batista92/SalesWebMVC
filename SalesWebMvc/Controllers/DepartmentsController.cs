using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>
            {
                new Department { Id = 1, Name = "Eletronics" },
                new Department { Id = 2, Name = "Clothes" }
            };
            return View(departments);
        }
    }
}
