using hello_aspx.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace hello_aspx.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        // url case insensitive
        // GET /User
        public String Index()
        {
            _logger.LogInformation("hello ==========>");
            return "hello, this is UserController.Index()";
        }

        // GET /User/Hello
        public String Hello()
        {
            return "hello, this is UserController.Hello()";
        }

        // GET /User/Add
        // will be transfered to string automatically
        public UserModel Add(long id, string name)
        {
            _logger.LogInformation("id=>{}, name=>{}, ", id, name);
            UserModel user = new UserModel(id, name);
            _logger.LogInformation("user=>{}, ", user);
            return user;
        }

        // return a View
        public IActionResult Update()
        { 
            return View();
        }
        
        // return a View
        public IActionResult Delete()
        {
            ViewResult view = View(); // ViewResult - _ViewStart.cshtml will be inherited
            _logger.LogInformation("view=============>");
            _logger.LogInformation(view.ToString());
            _logger.LogInformation(view.ViewName);
            _logger.LogInformation(view.ViewData.ToString());
            //_logger.loginformation(view.viewengine.tostring());
            _logger.LogInformation("view=============>");

            ViewData["title"] = "A标题A"; // case insensitive key
            ViewData["Deleted"] = "yes";
            return view;
        }
        
        // return a View
        public IActionResult Query()
        {
            return PartialView(); // PartialViewResult - _ViewStart.cshtml won't be inherited
        }

    }
}
