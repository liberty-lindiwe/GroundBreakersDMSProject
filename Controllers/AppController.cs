using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using DBMS.Data;

namespace DBMS.Controllers
{
    public class AppController : Controller
    {
        private readonly ILogger<AppController> logger;
        private readonly DMSContext ctx;

        public AppController(ILogger<AppController> logger, DMSContext ctx)
        {
            this.logger = logger;
            this.ctx = ctx;
        }


        public IActionResult Index()
        {
            ctx.Company.ToList();
            return View();
        }
        
    }
}
