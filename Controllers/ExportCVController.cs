using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuickCV.Models;

namespace QuickCV.Controllers
{
    public class ExportCVController : Controller
    {
        public IActionResult Preview(CVDetailsViewModel model)
        {
            return View(model);
        }
    }
}