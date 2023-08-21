using ASP_Core_Empty.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Core_Empty.Controllers
{
        //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        //[Route("")]
        ////[Route("Index")]
        //[Route("~/")]
        //[Route("~/Home")]
        public IActionResult Index() // this Index action method will work for HttpGet Request 
        {
            //About ViewData, ViewBag and TempData
            ////@ViewData["Data1"] = "hey this is data 1";
            ////@ViewData["Data2"] = 17;
            ////@ViewData["Data3"] = DateTime.Now.ToLongDateString();
            //string[] arr = { "Shubham", "Dhupar", "17" };
            ////@ViewData["Data4"] = arr;
            //ViewData["Name"] = "Shubham";
            //ViewBag.Data5 = 45;

            //ViewImport Part...
            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee{ID = 1, Name ="Shubham", Gender = "Male" },
            //    new Employee{ID = 2, Name ="Dhupar", Gender = "Male" }
            //};

            return View();
        }

        //this Index method code is related to ModelBinding concepts...
        //[HttpPost]
        //public string Index(Employee e) // this Index action method will work for HttpPost Request 
        //{
        //    return "Name : " + e.Name + " Gender : " + e.Gender + " Age : " + e.Age + " Discription : " + e.Description;
        //}

        [HttpPost]
        public IActionResult Index(Student std) // this Index action method will work for HttpPost Request 
        {
            return View();
            //this below code is used to check validation of the data via isValid attribute/property...
            //if (ModelState.IsValid)
            //{
            //    return "Name : " + std.Name;
            //}
            //else
            //{
            //    return "Validation Failed";
            //}
        }

        //[Route("About")]
        public IActionResult About()
        {
            //Part of ViewImport....
            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee{ID = 1, Name ="Shubham", Gender = "Male" },
            //    new Employee{ID = 2, Name ="Dhupar", Gender = "Male" }
            //};
            return View();
        }
        //[Route("{id?}")]
        public string Details(int id,string name)
        {
            return "Id is " + id + " and Name is " + name;       
        }
    }
}
 