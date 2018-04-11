using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheBoredProfessor2.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: /<controller>/
        
        public IActionResult Index()
        {
            List<string> researchpapers = new List<string>();


            researchpapers.Add("SOemthing about waves ");
            researchpapers.Add("earth science  ");
            researchpapers.Add("the stars ");



            ViewBag.researchpapers = researchpapers; 

            return View();
        }

        public IActionResult SearchKeywords()
        {
            return View();
        }
    }
}
