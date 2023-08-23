using ASP_Core_Empty.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace ASP_Core_Empty.Controllers
{
        //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly StudentDBContext studentDB;

        public HomeController(StudentDBContext studentDB)
        {
            this.studentDB = studentDB;
        }
        //[Route("")]
        ////[Route("Index")]
        //[Route("~/")]
        //[Route("~/Home")]
        public async Task<IActionResult> Index() // this Index action method will work for HttpGet Request 
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

            //this below code is the part of StudentDBContext
            var stdData = await studentDB.Students.ToListAsync(); 
            return View(stdData);
        }

        //this method is used to create a field in the existing table of data....
        public async Task<IActionResult> Create(Student std)
        {
            if (ModelState.IsValid)
            {
                await studentDB.Students.AddAsync(std);
                await studentDB.SaveChangesAsync();
                return RedirectToAction("Index","Home");
            }

            return View(std);
        }

        //this method is used to show the details of the particular ID of student from DBSet Students table on a blank page....
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null || studentDB.Students == null)
            {
                return NotFound();
            }
            var stdData = await studentDB.Students.FirstOrDefaultAsync(x => x.Id == id); // this will match the Id from student table to the parameter of Details method and then returns result.
            if (stdData == null)
            {
                return NotFound();
            }
            return View(stdData);
        }

        //this method is used to update the data inside the table....
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || studentDB.Students == null)
            {
                return NotFound();
            }
            var stdData = await studentDB.Students.FindAsync(id); //this line of code will find the particular Id from studnets table and then perform update operation.
            if (stdData == null)
            {
                return NotFound();
            }
            return View(stdData);
        }

        [HttpPost] // this below method is for post requests the Edit methods....
        public async Task<IActionResult> Edit(int? id,Student std)
        {
            if (ModelState.IsValid)
            {
                studentDB.Students.Update(std);
                studentDB.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            } 

            return View(std);
        }

        //this method is used to delete a particular field of student from DBSet students table....
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || studentDB.Students == null)
            {
                return NotFound();
            }
            var stdData = await studentDB.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (stdData == null)
            {
                return NotFound();
            }
            return View(stdData);
        }

        //this Index method code is related to ModelBinding concepts...
        //[HttpPost]
        //public string Index(Employee e) // this Index action method will work for HttpPost Request 
        //{
        //    return "Name : " + e.Name + " Gender : " + e.Gender + " Age : " + e.Age + " Discription : " + e.Description;
        //}

        //this Index method is associated with Valdation of model properties and their values.
        //[HttpPost]
        //public IActionResult Index(Student std) // this Index action method will work for HttpPost Request 
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ModelState.Clear(); // this method is used to clear text from all input fields when submitted...
        //    }
        //    return View();
        //this below code is used to check validation of the data via isValid attribute/property...
        //if (ModelState.IsValid)
        //{
        //    return "Name : " + std.Name;
        //}
        //else
        //{
        //    return "Validation Failed";
        //}
        //}

        //[Route("About")]
        //public IActionResult About()
        //{
        //    //Part of ViewImport....
        //    //List<Employee> employees = new List<Employee>()
        //    //{
        //    //    new Employee{ID = 1, Name ="Shubham", Gender = "Male" },
        //    //    new Employee{ID = 2, Name ="Dhupar", Gender = "Male" }
        //    //};
        //    return View();
        //}
        ////[Route("{id?}")]
        //public string Details(int id,string name)
        //{
        //    return "Id is " + id + " and Name is " + name;       
        //}
    }
}
 