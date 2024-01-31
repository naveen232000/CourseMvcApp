using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseMvcApp.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
       static List<Course> courses=new List<Course>() { 
        new Course(){Cid=1,CName="Java Basic",CFee=10000,Technology="Java",StartDate=new DateTime(day:12,month:12,year:2022),EndDate=new DateTime(day:28,month:12,year:2022)},
        new Course(){Cid=2,CName="Python Advanced",CFee=12000,Technology="Python",StartDate=new DateTime(day:27,month:11,year:2023),EndDate=new DateTime(day:10,month:12,year:2022)},
        new Course(){Cid=3,CName="C# For Beginers",CFee=14000,Technology="c#",StartDate=new DateTime(day:05,month:12,year:2022),EndDate=new DateTime(day:05,month:01,year:2023)},
        new Course(){Cid=4,CName="Introduction to C++",CFee=8000,Technology="c++",StartDate=new DateTime(day:10,month:10,year:2022),EndDate = new DateTime(day:30, month:10, year:2022)},
        new Course(){Cid=5,CName=".NET Web Application",CFee=15000,Technology=".net",StartDate=new DateTime(day:15,month:09,year:2022),EndDate=new DateTime(day:20,month:10,year:2022)},
        };
        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                courses.Add(course);
                return RedirectToAction("Index");
            }
            return View(course);
        }

    }

  
}