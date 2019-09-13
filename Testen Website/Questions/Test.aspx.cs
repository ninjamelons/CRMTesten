using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HtmlAgilityPack;
using Testen_Website.Models;

namespace Testen_Website.Questions
{
    public partial class Test : System.Web.UI.Page
    {
        private const string FitAnalysis = "Fit Analysis";
        private const string QualAnalysis = "Qualifications Analysis";
        QuestionsContainer qCont = new QuestionsContainer();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WriteQuestionnaire(qCont.GetQuestionsAnalysis, FitAnalysis);
                SwitchTitle(
                    () => buttonBack.Visible = true,
                    () => buttonBack.Visible = false,
                    Session["currentPage"]);
            }
        }

        private void WriteQuestionnaire(Func<List<Question>> quests, string title)
        {
            List<Question> analysis = quests();

            questionsH.InnerText = title;
            Session["currentPage"] = title;
            questionsContainer.InnerHtml = "";

            for (int i = 0; i < analysis.Count; i++)
            {
                //Set template div for the question
                Question q = (Question) analysis[i];

                questionsContainer.InnerHtml += $"<div id=\"question{q.QuestionId}\" class=\"row\">" +
                                                $"   <h4>{q.QuestionValue}</h4>";

                for (int j = 0; j < q.Answers.Length; j++)
                {
                    string answer = (string) q.Answers.GetValue(j);
                    attachAnswersBoxes(i, j, q, answer, questionsContainer);
                }

                if (i != analysis.Count - 1)
                {
                    questionsContainer.InnerHtml += "<hr style=\"border: 0;height: 1px; background-image: linear-gradient(to right, rgba(0, 0, 0, 0), rgba(0, 0, 0, 0.75), rgba(0, 0, 0, 0));\">";
                }
                else
                {
                    questionsContainer.InnerHtml += "<br>";
                }
                questionsContainer.InnerHtml += "</div>";
            }
        }

        //qi is the question index in the question collection
        //ai is the answer index in the answer array
        //q is the question object
        //answer is the current answer in the for loop
        //ctrl is the HTML container all of the questions will be held in
        private void attachAnswersBoxes(int qi, int ai, Question q, string answer,
            System.Web.UI.HtmlControls.HtmlGenericControl ctrl)
        {
            string contClass = "";
            switch (q.InputType)
            {
                case "radio":
                    contClass = "checkbox";
                    break;
                case "checkbox":
                    contClass = "radio";
                    break;
                default:
                    contClass = "checkbox";
                    break;
            }

            //TODO - Function to select already checked boxes based on Session storage
            //Value: Question name/identifier
            ctrl.InnerHtml += $"<div class=\"{contClass}\">" +
                              $"<label><input name=\"{"q" + qi}\" type=\"{q.InputType}\" value=\"{("q"+q.QuestionId) + "-" + q.Points.GetValue(ai) + "-" + q.PointType}\"/> {answer} </label></div>";
        }

        //TODO - Currently can only go back to home page
        protected void ButtonBack(object sender, EventArgs e)
        {
            ProcessPointsOnBack();

            SwitchTitle(
                () => Response.Redirect("~"),
                () => WriteQuestionnaire(qCont.GetQuestionsAnalysis, FitAnalysis),
                Session["currentPage"].ToString());
        }

        protected void ButtonNext(object sender, EventArgs e)
        {
            if (!Session["points"].ToString().Contains(ProcessPoints()))
            {
                Session["points"] += ProcessPoints();
            }

            SwitchTitle(
                () => WriteQuestionnaire(qCont.GetQuestionsQualifications, QualAnalysis),
                () => Response.Redirect("/Questions/Conclusion"),
                Session["currentPage"].ToString());
        }

        private string ProcessPoints()
        {
            bool getQ = true;
            string points = "";

            for (int i = 0; getQ; i++)
            {
                if (Request.Form["q" + i] != null)
                {
                    if (!points.Equals(""))
                    {
                        points += "," + Request.Form["q" + i];
                    }
                    else
                    {
                        points = Request.Form["q" + i];
                    }
                }
                else
                {
                    getQ = false;
                }
            }

            return points;
        }

        //TODO - Add/Subtract points from session when pressing back
        private void ProcessPointsOnBack()
        {
            return;

            string pointStr = ProcessPoints();

            if (String.IsNullOrEmpty(pointStr))
                return;

            //If the Session already has the exact same selections then do nothing
            if (!Session["points"].ToString().Contains(pointStr))
            {

            }
            //Home page should clear session points
        }

        private void SwitchTitle(Action fit, Action qual, object value)
        {
            if (value != null)
            {
                switch (value)
                {
                    case FitAnalysis:
                        fit();
                        break;
                    case QualAnalysis:
                        qual();
                        break;
                    default:
                        fit();
                        break;
                }
            }
        }
    }
}