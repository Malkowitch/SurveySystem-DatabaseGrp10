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
        private SurveySystemDBEntities db = new SurveySystemDBEntities();

        [HttpGet]
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult Survey()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Survey(int adminId, string survTitle, List<string> questions)
        {

            //ICollection<Question> listQuestions = new List<Question>();


            Survey newSurv = new Survey
            {
                AdminId = adminId,
                Administrator = db.Administrator.Where(x => x.AdminId == adminId).First(),
                SurveyTitle = survTitle
            };
            db.Survey.Add(newSurv);
            db.SaveChanges();
            for (int i = 0; i < questions.Count; i++)
            {
                Question que = new Question
                {
                    Answer = null,
                    AnswerRequired = false,
                    InputId = db.InputType.Where(x => x.Type.Equals("text")).First().InputId,
                    MultiOption = null,
                    QuestionDesc = "blank",
                    QuestionText = questions[i],
                    RatingMaxValue = null,
                    SurveyId = db.Survey.Max(x => x.SurveyId)
                };
                db.Question.Add(que);
                db.SaveChanges();
                //listQuestions.Add(que);
            };

            return RedirectToAction("Index", "Home");
        }

        public ActionResult MyProfile()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Surveys()
        {
            List<Survey> survs = db.Survey.ToList();
            return View(survs);
        }
    }
}