﻿using hello_aspx.Models;
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
    }
}
