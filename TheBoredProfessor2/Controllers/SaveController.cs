﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheBoredProfessor2.Controllers
{
    [Route("api/[controller]")]
    public class SaveController : Controller
    {
        // GET: api/<controller>


    


        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
            View();
        }


    }
        
}
