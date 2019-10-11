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
        private const string FitAnalysis = "CRM Testen - side 1 af 2";
        private const string QualAnalysis = "CRM Testen - side 2 af 2";
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

        private void WriteQuestionnaire(Func<List<QuestionRep>> quests, string title)
        {
            List<QuestionRep> analysis = quests();

            questionsH.InnerText = title;
            Session["currentPage"] = title;

            QuestionsList.DataSource = analysis;
            QuestionsList.DataBind();
        }

        protected void ButtonNext(object sender, EventArgs e)
        {
            if (Session["points"].Equals(""))
                Session["points"] += ProcessPoints();
            else
                Session["points"] += "," + ProcessPoints();

            SwitchTitle(
                () =>
                {
                    WriteQuestionnaire(qCont.GetQuestionsQualificationsRep, QualAnalysis);
                    buttonNext.Text = "Vis resultat";
                },
                () => Response.Redirect("/Questions/Conclusion"),
                Session["currentPage"].ToString());
        }

        private string ProcessPoints()
        {
            var allKeys = Request.Form.AllKeys;
            var list = new ArrayList();

            foreach (var key in allKeys)
            {
                if (key.Contains("quest"))
                    list.Add(Request.Form[key]);
            }

            return string.Join(",", list.ToArray());
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