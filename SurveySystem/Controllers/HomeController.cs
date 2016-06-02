﻿using SurveySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurveySystem.Controllers
{
    public class HomeController : Controller
    {
        private SurveySystemDBEntities db = new SurveySystemDBEntities();

        [HttpGet]
        public ActionResult Index()
        {
            List<Question> questions = db.Question.ToList();
            return View(questions);
        }

        public ActionResult Survey()
        {
            return View();
        }


        public ActionResult MyProfile()
        {
            return View();
        }

        public ActionResult Surveys()
        {
            return View();
        }
    }
}