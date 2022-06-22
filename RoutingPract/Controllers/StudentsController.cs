using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoutingPract.Models;


namespace RoutingPract.Controllers
{
    [RoutePrefix("Students")]
    public class StudentsController : Controller
    {
        [Route(" ")]
        // GET: Students
        public ActionResult Getallstudents()
        {
            //select list template for creating view to get data for all students
            var students = Students();
            return View(students);

        }
        [Route("{id:int}")]
        public ActionResult StudentDetails(int id)
        {
            var student = Students().FirstOrDefault(x => x.Id == id);
            return View(student);

            //select details template for creating view 

        }
        [Route("{id}/Address")]
        public ActionResult StudentAddress(int id)
        {
            var address = Students().Where(x=> x.Id == id).Select(x => x.Address).FirstOrDefault();
            return View(address);
        }
        private List<Student> Students()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "sid",
                    Class = "First",
                    Address = new Address()
                    {
                        Address1 = "this is student 1 address",
                        city = "Badlapur",
                        HomeNumbr = "room no 303"
                    }
                },
                new Student() { Id = 2,
                    Name = "Shubham",
                    Class = "second",
                    Address = new Address() { Address1 = "this is 2 address",
                        city = "new mumbai", HomeNumbr = "405"
                    }
                },

                new Student()
                {
                    Id = 3,
                    Name = "Jitendra",
                    Class = "third",
                    Address = new Address()
                    {
                        Address1 = "this is 3 address",
                        city = "wada",
                        HomeNumbr = "505"
                    },
                }
            };
        }
    }
}