using IntroductionProject.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace IntroductionProject.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            //User user1 = new Models.User();
            //user1.Id = 1;

            //User num = new User()
            //{
            //    Id = 1, 
            //    Name = ,
            //};

            //string data = TempData["NYY"].ToString();
            //ViewBag.data = data;
            ViewBag.user = new User
            {
                Id = 1,
                Name = "Muhammad Hammad",
                Password = "123x",
                IsActive = true,
                Email = "hammad@its.com"
            };

            return View("Login");
        }

        public ActionResult UsersList()
        {
            //List<User> UserList1 = new List<Models.User>();

            //User user1 = new User
            //{
            //    Id = 1,
            //    Name = "Muhammad Hammad",
            //    Password = "123x",
            //    IsActive = true,
            //    Email = "hammad@its.com"
            //};

            //User user2 = new Models.User();
            //user2.Id = 2;
            //user2.Name = "Muhammad Ahmed";
            //user2.Email = "test";

            //User user3 = new Models.User();
            //user3.Id = 2;
            //user3.Name = "Muhammad Ahmed";
            //user3.Email = "test";

            //User user4 = new Models.User();
            //user4.Id = 2;
            //user4.Name = "Muhammad Ahmed";
            //user4.Email = "test";

            //UserList1.Add(user1);
            //UserList1.Add(user2);
            //UserList1.Add(user3);
            //UserList1.Add(user4);

            //List<User> usersList = new List<Models.User>
            //{
            //    new Models.User
            //    {
            //        Id = 1,
            //        Name = "Muhammad Hammad",
            //        Password = "123x",
            //        IsActive = true,
            //        Email = "hammad@its.com"
            //    },
            //    new Models.User
            //    {
            //        Id = 2,
            //        Name = "Muhammad Ahmed",
            //        Password = "123x",
            //        IsActive = true,
            //        Email = "hammad@its.com"
            //    },
            //    new Models.User
            //    {
            //        Id = 3,
            //        Name = "Muhammad Ahsan",
            //        Password = "123x",
            //        IsActive = true,
            //        Email = "hammad@its.com"
            //    },
            //    new Models.User
            //    {
            //        Id = 4,
            //        Name = "Muhammad Hassan",
            //        Password = "123x",
            //        IsActive = true,
            //        Email = "hammad@its.com"
            //    }
            //};

            ViewData["FirstNmae"] = "Raouf Yasin";
            TempData["Role"] = "Administrator";
            ViewBag.UsersList = new List<Models.User>
            {
                new Models.User
                {
                    Id = 1,
                    Name = "Muhammad Hammad",
                    Password = "123x",
                    IsActive = true,
                    Email = "hammad@its.com"
                },
                new Models.User
                {
                    Id = 2,
                    Name = "Muhammad Ahmed",
                    Password = "123x",
                    IsActive = true,
                    Email = "hammad@its.com"
                },
                new Models.User
                {
                    Id = 3,
                    Name = "Muhammad Ahsan",
                    Password = "123x",
                    IsActive = true,
                    Email = "hammad@its.com"
                },
                new Models.User
                {
                    Id = 4,
                    Name = "Muhammad Hassan",
                    Password = "123x",
                    IsActive = true,
                    Email = "hammad@its.com"
                }
            };

            return View();
        }
    }
}