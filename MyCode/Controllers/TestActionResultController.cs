using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCode.Core.ActionResult;
using MyCode.Models;

namespace MyCode.Controllers
{
    [RoutePrefix("test-xml-result")]
    public class TestActionResultController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            var data = new List<Employe>
            {
                new Employe
                {
                    Id = 1,
                    Name = "Employe 1"
                },
                new Employe
                {
                    Id = 2,
                    Name = "Employe 2"
                }
            };
            return new XmlResult(data);
        }

        [Route("csv")]
        public ActionResult CsvTest()
        {
            var data = new List<Employe>
            {
                new Employe
                {
                    Id = 1,
                    Name = "Employe 1"
                },
                new Employe
                {
                    Id = 2,
                    Name = "Employe 2"
                }
            };
            return new CsvResult(data, "EmpData");
        }
    }
}