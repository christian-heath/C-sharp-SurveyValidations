using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using dojosurveyvalidations.Models;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        // Requests
        [HttpGet("")]
        public IActionResult index()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult result(Survey survey)
        {
            if(ModelState.IsValid)
            {
                return View(survey);
            }
            else{
                return View("index");
            }
        }
    }
}