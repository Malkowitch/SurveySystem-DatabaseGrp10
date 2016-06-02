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

        [HttpGet]
        public ActionResult Answering(int surveyId)
        {
            Survey surv = db.Survey.Where(x => x.SurveyId == surveyId).First();
            return View(surv);
        }
        [HttpPost]
        public ActionResult Answering(int participantId, List<int> questionId, List<string> answerText)
        {
            Answer newAnsw = null;
            AnswerText answText = null;

            for (int i = 0; i < questionId.Count; i++)
            {
                newAnsw = new Answer
                {
                    ParticipantId = participantId,
                    QuestionId = questionId[i],
                };
                db.Answer.Add(newAnsw);
                db.SaveChanges();
                if (db.Question.Where(x => x.QuestionId == questionId[i]).First().InputType.Type.Equals("Text"))
                {
                    answText = new AnswerText
                    {
                        TextInput = answerText[i],
                        AnswerId = db.Answer.First().AnswerId
                    };
                    db.AnswerText.Add(answText);
                    db.SaveChanges();
                }
            };

            return View("index");
        }
    }
}