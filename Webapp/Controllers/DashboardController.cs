using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stablex.DataStructure.ModelView;
using WebApp.Helpers;

namespace WebApp.Controllers
{
    [AuthorizeRoles]
    public class DashboardController : Controller
    {
        [Route("/Dashboard")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
