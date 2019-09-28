using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApp.DAL;
using FirstApp.Models;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public ActionResult Index()
        {

            return View(_employeeRepository.GetAllEmployee());
        }

        public ActionResult Details(int id)
        {
            return View(_employeeRepository.GetEmployee(id));
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}