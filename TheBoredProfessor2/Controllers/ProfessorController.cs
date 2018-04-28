using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheBoredProfessor2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheBoredProfessor2.Controllers
{
   
    public class ProfessorController : Controller
    {
        

        // GET: /<controller>/
       
        public IActionResult Index()
        {        

           

            return View();
        }

       

    
    }
}
