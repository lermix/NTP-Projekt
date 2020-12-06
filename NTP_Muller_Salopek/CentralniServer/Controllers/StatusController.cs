using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentralniServer.Controllers
{
    public class StatusController : Controller
    {
        public string Index()
        {
            return "OK";
        }
    }
}
