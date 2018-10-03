using demo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        private List<Cert> cert;
        public HomeController()
        {
            cert = new List<Cert>
            {
                new Cert()
                { Id = 000, FirstName = "testFirst0", LastName = "testLast0", CertName = "ExpiredCert", ExpDate = "2017-01-01", Email = "test0@emal.com" },
                new Cert()
                { Id = 002, FirstName = "testFirst2", LastName = "testLast2", CertName = "15DayCert", ExpDate = "2018-10-15", Email = "test2@emal.com" },
                new Cert()
                { Id = 001, FirstName = "testFirst1", LastName = "testLast1", CertName = "30DayCert", ExpDate = "2018-10-25", Email = "test1@emal.com" },
                new Cert()
                { Id = 003, FirstName = "testFirst3", LastName = "testLast3", CertName = "Over30DayCert", ExpDate = "2020-01-01", Email = "test3@emal.com" }
            };
        }

        public ActionResult Index()
        {
            return View(cert);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}