using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Web;
using System.Web.Razor.Generator;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebPages;
using Testen_Website.Models;

namespace Testen_Website.Questions
{
    public partial class Conclusion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["conclusion"] = true;

            var rec = "";

            if (Session["points"] != null)
            {
                
                rec = ReturnRecommendation();
            }

            var title = "";
            var description = "";

            if (rec.Equals("360"))
            {
                title = "Vi Foreslår";

                SystemImage.AlternateText = "360 Business Tool";
                SystemImage.ImageUrl = "~/Content/360logo.png";

                description = 
                    "<div>" +
                    "<p><a href=\"https://www.360businesstool.com/ \">360 Business Tool</a> er en CRM løsning, der indeholder alle de funktioner, en virksomhed har brug for. </p>" +
                    "<p>CRM, time/sag, tidsregistrering, tilbudsgivning, budgettering, fakturering, marketing, nyhedsbreve og meget mere. </p>" +
                    "<p>Modulopbygget så du kan starte simpelt og slå flere moduler til, efterhånden som din forretning vokser. </p>" +
                    "<br >" +
                    "<p>Tak for at du gjorde brug af CRM Testen.</p>" +
                    "<p>Hvis du har spørgsmål, er du velkommen til at <a href=\"https://www.360businesstool.com/kontakt/ \">indtaste dine kontaktinformationer her</a>," +
                    "så vil du blive kontaktet af en CRM specialist hurtigst muligt. </p>" +
                    "<p class=\"subheading\">CRM Testen er sponsoreret af <a href=\"https://www.speople.dk/ \">sPeople</a></p>" +
                    "</div>";
            } else if (rec.Equals("small")) {
                title = "Vi har nogle forslag";
                
                description =
                    "<div>" +
                    "<p>Baseret på dine svar, foreslår vi at du overvejer følgende CRM systemer:</p>" +
                    "<ul><li>Billig CRM</li> <li>Channel CRM</li> <li>SkyView CRM</li> <li>Proff CRM</li></ul>" +
                    "<p>Tak for at du gjorde brug af CRM Testen, og held og lykke med at finde det rette CRM System.</p>" +
                    "<p class=\"subheading\">CRM Testen er sponsoreret af <a href=\"https://www.speople.dk/ \">sPeople</a></p>" +
                    "</div>";
            } else if (rec.Equals("big")) {
                title = "Vi har nogle forslag";
                
                description =
                    "<div>" +
                        "<p>Baseret på dine svar, foreslår vi at du overvejer følgende CRM systemer:</p>" +
                        "<ol><li><a href=\"https://www.salesforce.com/ \">Salesforce</a>" +
                            "</li> <li><a href=\"https://dynamics.microsoft.com/en-us/ \">Microsoft CRM</a></li>" +
                            "<li><a href=\"https://www.360businesstool.com/ \">360 Business Tool</a></li>" +
                        "</ol>" +
                        "<p>Tak for at du gjorde brug af CRM Testen, og held og lykke med at finde det rette CRM System.</p>" +
                        "<p>Hvis du har spørgsmål, er du velkommen til at <a href=\"https://www.360businesstool.com/kontakt/ \">indtaste dine kontaktinformationer her</a>," +
                        "så vil du blive kontaktet af en CRM specialist hurtigst muligt. </p>" +
                        "<p class=\"subheading\">CRM Testen er sponsoreret af <a href=\"https://www.speople.dk/ \">sPeople</a></p>" +
                    "</div>";
            }

            //Place holder text & possible structure
            SystemTitle.InnerText = title;

            SystemDesc.Controls.Add(new LiteralControl(description));
        }

        private string ReturnRecommendation()
        {
            var recommendation = "";

            string pointString = (string) Session["points"];
            //question 202 - answers: max3,max10,max30,max100,max1000,max1000+
            //205 - no, 360

            if (pointString.Contains("no"))
            {
                if (pointString.Contains("max3,") || pointString.Contains("max10,"))
                {
                    recommendation = "small";
                }
                else
                {
                    recommendation = "big";
                }
            }
            else
            {
                if (pointString.Contains("max3,"))
                {
                    recommendation = "small";
                } else if (pointString.Contains("max1000,") || pointString.Contains("max1000+"))
                {
                    recommendation = "big";
                }
                else
                {
                    recommendation = "360";
                }
            }

            return recommendation;
        }
    }
}