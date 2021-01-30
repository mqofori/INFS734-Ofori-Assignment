using Microsoft.AspNetCore.Mvc;
using System;
using INFS734_Ofori_Assignment.Models;
using System.Linq;

namespace INFS734_Ofori_Assignment.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View(Repository.Tasks);
        }

        [HttpGet]
        public ViewResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SaveTask(Task newTask)
        {
            if (ModelState.IsValid)
            {
                Repository.AddTask(newTask);
                return View("SavedTask", newTask);
            }
            else
            {
                // there is a validation error
                return View("AddTask");
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Tasks);
        }
    }
}
