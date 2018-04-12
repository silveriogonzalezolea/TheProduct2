using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheBoredProfessor2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheBoredProfessor2.Controllers
{
    public class ProfessorController : Controller
    {
        static private List<ResearchPaper> ResearchPapers = new List<ResearchPaper>();
       
        // GET: /<controller>/
        
        public IActionResult Index()
        {        

            ViewBag.researchpapers = ResearchPapers; 

            return View();
        }

        public IActionResult SearchKeywords()
        {
            return View();
        }

        [HttpPost]
        [Route("/Professor/SearchKeywords")]
        public IActionResult NewSearch(string keywords ,string absract = "")
        {
            ResearchPaper newPaper = new ResearchPaper
            {
                Keywords = keywords,
                Absract = absract,
            };
            ResearchPapers.Add(newPaper);

            return Redirect("/Professor");
        }

        public IActionResult Save()
        {
            ViewBag.title = "Save A Paper";
            ViewBag.researchpapers = ResearchPapers;

            return View();
        }

        [HttpPost]
        public IActionResult Save()
        {

        }
    }
}
