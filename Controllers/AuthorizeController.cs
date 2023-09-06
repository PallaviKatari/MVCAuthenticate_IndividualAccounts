using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthenticate_IndividualAccounts.Controllers
{
    public class AuthorizeController : Controller
    {
        // GET: Authorize
        [Authorize(Users ="john@gmail.com")]
        public ActionResult Index()
        {
            return Content("Authorize Users Only");
        }
        [AllowAnonymous]
        public ActionResult Index1()
        {
            return Content("Public Users");
        }
    }
}