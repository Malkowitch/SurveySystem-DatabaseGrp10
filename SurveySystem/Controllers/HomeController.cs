using SurveySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurveySystem.Controllers
{
    public class HomeController : Controller
    {
        private SurveyConnection db = new SurveyConnection();
        
        public ActionResult Index()
        {
            List<Question> questions = db.QueestionDB.ToList();
            return View(questions);
        }
    }
}