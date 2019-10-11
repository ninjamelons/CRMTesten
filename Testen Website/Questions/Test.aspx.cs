using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Testen_Website.Models;

namespace Testen_Website.Questions
{
    public partial class Test : System.Web.UI.Page
    {
        //Page title
        private const string FitAnalysis = "CRM Testen - side 1 af 2";
        private const string QualAnalysis = "CRM Testen - side 2 af 2";

        //Questions source - TODO - Can be moved to a database
        QuestionsContainer qCont = new QuestionsContainer();

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["conclusion"])
                Response.Redirect("~/Default.aspx");

            if (!IsPostBack)
            {
                WriteQuestionnaire(qCont.GetQuestionsAnalysisRep, FitAnalysis);
            }
        }
        
        //Set questions and all other properties
        private void WriteQuestionnaire(Func<List<QuestionRep>> quests, string title)
        {
            List<QuestionRep> analysis = quests();

            questionsH.InnerText = title;
            Session["currentPage"] = title;

            QuestionsList.DataSource = analysis;
            QuestionsList.DataBind();
        }

        //Process points and redirect to the next page
        protected void ButtonNext(object sender, EventArgs e)
        {
            //Get all answered questions' values
            var allKeys = Request.Form.AllKeys;
            var list = new ArrayList();

            foreach (var key in allKeys)
            {
                if (key.Contains("quest"))
                    list.Add(Request.Form[key]);
            }

            //Convert list of answered values to a single string
            var processedPoints = string.Join(",", list.ToArray());

            //Add all answers to Session points
            if (Session["points"].Equals(""))
                Session["points"] += processedPoints;
            else
                Session["points"] += "," + processedPoints;

            //Redirect
            SwitchTitle(
                () =>
                {
                    WriteQuestionnaire(qCont.GetQuestionsQualificationsRep, QualAnalysis);
                    buttonNext.Text = "Vis resultat";
                },
                () => Response.Redirect("/Questions/Conclusion"),
                Session["currentPage"].ToString());
        }

        //switch for page checking with delegates
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