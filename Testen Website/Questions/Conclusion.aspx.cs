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
        /*
         * If the max or min points in a category are greater than another's
         * it will skew the data in favour of the category with greater values
         *
         * Can decrease/increase bias through Modifier
         */

        // Modifier < 1.0f : Decreases need for CRM Tool
        // Modifier = 1.0f : Neutral effect on need for CRM Tool
        // Modifier > 1.0f : Increases need for CRM Tool
        
        private const float NeedModifier = 1.0f;
        private const float QualModifier = 1.0f;

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["conclusion"] = true;

            var rec = "";

            if (Session["points"] != null)
            {
                
                rec = ReturnRecommendation();
            }

            /*
            float threshold = 0.0f;
            if (Session["points"] != null)
            {
                threshold = ReturnThreshold();
            }

            if (threshold == 0.0f)
            {
                //Didn't fill out any questions or just wow
            } else if (threshold < 0.4)
            {
                //TODO - Recommend nothing?
            } else if (threshold >= 0.4 && threshold < 0.7)
            {
                //TODO - Recommend smaller system?
            } else if (threshold >= 0.7)
            {
                //TODO - Recommend big system?
            }
            */

            var title = "";

            if (rec.Equals("360"))
            {
                title = "360";
            } else if (rec.Equals("small"))
            {
                title = "small";
            } else if (rec.Equals("big"))
            {
                title = "big";
            }

            //Place holder text & possible structure
            SystemTitle.InnerText = title;

            SystemImage.AlternateText = "360 Business Tool";
            SystemImage.ImageUrl = "~/Content/360logo.png";

            SystemDesc.InnerHtml =
                "<p><a href=\"https://www.360businesstool.com/ \">360 Business Tool</a> er en CRM løsning, der indeholder alle de funktioner, en virksomhed har brug for. </p>" +
                "<p>CRM, time/sag, tidsregistrering, tilbudsgivning, budgettering, fakturering, marketing, nyhedsbreve og meget mere. </p>" +
                "<p>Modulopbygget så du kan starte simpelt og slå flere moduler til, efterhånden som din forretning vokser </p>";
        }

        private string ReturnRecommendation()
        {
            var recommendation = "";

            string pointString = (string) Session["points"];
            //202 - max3,max10,max30,max100,max1000,max1000+
            //205 - no

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

        protected void EmailForm_OnClick(object sender, EventArgs e)
        {
            if (!Request.Form["email"].IsEmpty())
            {
                //TODO - Save the email somewhere

                SmtpClient smtpClient = new SmtpClient("mail.MyWebsiteDomainName.com", 25);

                smtpClient.Credentials = new System.Net.NetworkCredential("info@MyWebsiteDomainName.com", "password");
                smtpClient.UseDefaultCredentials = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                MailMessage mail = new MailMessage();

                mail.Subject = "CRM Test Results";
                mail.Body = "";

                string htmlBody = HtmlEmailFormatter.GetHtmlFile(ReturnRecommendation());

                ContentType mimeType = new System.Net.Mime.ContentType("text/html");
                // Add the alternate body to the message.
      
                AlternateView alternate = AlternateView.CreateAlternateViewFromString(htmlBody, mimeType);
                mail.AlternateViews.Add(alternate);

                mail.From = new MailAddress("info@MyWebsiteDomainName", "CRM Test");
                mail.To.Add(new MailAddress(Request.Form["email"]));

                smtpClient.Send(mail);
            }
        }

        private Dictionary<string, int?> ReadSessionStrings(int count)
        {
            //Structure: Session["points"] = "'q'+QuestiondId-PointString, ..."
            string pointsString = (string) Session["points"];
            string[] pointsArray = pointsString.Split(',');

            Dictionary<string, int?> pointDict = new Dictionary<string, int?>();

            foreach (string pointS in pointsArray)
            {
                #region Split String

                //Array with details of the questionId, number of points, & Point type
                var pointDet = pointS.Split('-');

                //Question ID = "q102" - Converted to int - 102
                int qId = 0;
                Int32.TryParse(pointDet.GetValue(0).ToString().Substring(1), out qId);

                //Points = "360"
                string pointValue = pointDet.GetValue(1).ToString();

                #endregion

                if (pointDict[pointValue] != null)
                {
                    pointDict[pointValue] += 1;
                }
                else
                {
                    pointDict.Add(pointValue, 0);
                }
            }

            return pointDict;
        }

        //Returns the Threshold used in determining the page layout
        private float ReturnThreshold()
        {
            int NumberOfTypes = 2;
            
            //Returns List of points - Each index is a point type
            // [0] - Need
            // [1] - Qualification
            List<List<float>> allPoints = ReadSessionPoints(NumberOfTypes);

            //Array of the Max points in each point type
            //Use to get normalized value for points
            List<Array> maxMinPoints = MaxPointsPerType(NumberOfTypes);

            //Apply modifier to points - default 1.0f - unchanged
            List<List<float>> modifiedPoints = allPoints;
            var sumArray = new float[NumberOfTypes];

            for (int i = 0; i < NumberOfTypes; i++)
            {
                for (int j = 0; j < allPoints[i].Count; j++)
                {
                    //TODO - Figure out a way to change this so that the code doesn't need to be touched when a new point type is added
                    if (i == 0)
                    {
                        modifiedPoints[i][j] *= NeedModifier;
                        sumArray[i] += modifiedPoints[i][j];
                    } else if (i == 1)
                    {
                        modifiedPoints[i][j] *= QualModifier;
                        sumArray[i] += modifiedPoints[i][j];
                    }
                }
            }

            //Returns the average point count in each point type
            var avgArray = new float[NumberOfTypes];
            for (int i = 0; i < NumberOfTypes; i++)
            {
                avgArray[i] = sumArray[i] / modifiedPoints[0].Count;
            }
            
            //Array of Normalized points in each point type - 0.0f-1.0f
            //Percentage of the max number of points possible in the type
            float[] normalPoints = new float[NumberOfTypes];

            //Normalize points between 0-1
            for (int i = 0; i < NumberOfTypes; i++) //All points
            {
                //Z = (x(i) - min(x)) / (max(x) - min(x))
                var fdjso = ((float)avgArray[i] - (float)(int)maxMinPoints[i].GetValue(1)) /
                            ((float)(int)maxMinPoints[i].GetValue(0) - (float)(int)maxMinPoints[i].GetValue(1));
                normalPoints[i] = fdjso;
            }

            float sum = 0;
            //Average of normalized points as threshold
            foreach (float normalPoint in normalPoints)
            {
                sum += normalPoint;
            }
            
            return sum / normalPoints.Length;
        }


        //Returns the points gathered in the test in an array
        //Each index is a different point type
        private int[] ReadSessionPointsSum()
        {
            //Structure: Session["points"] = "'q'+QuestiondId-Points-PointType, ..."
            string pointsString = (string) Session["points"];
            string[] pointsArray = pointsString.Split(',');

            int needP = 0;
            int qualP = 0;

            foreach (string pointS in pointsArray)
            {
                #region Split String

                //Array with details of the questionId, number of points, & Point type
                var pointDet = pointS.Split('-');

                //Question ID = "q102" - Converted to int - 102
                int qId = 0;
                Int32.TryParse(pointDet.GetValue(0).ToString().Substring(1), out qId);

                //Points = "1" - Converted to int - 1
                int points = 0;
                Int32.TryParse(pointDet.GetValue(1).ToString(), out points);

                //Point Type = "need" / "qualification"
                string pointType = pointDet.GetValue(2).ToString();

                #endregion

                StringTypeSwitch(
                    () => needP += points,
                    () => qualP += points,
                    pointType);
            }

            return new[] {needP, qualP};
        }

        private List<List<float>> ReadSessionPoints(int count)
        {
            //Structure: Session["points"] = "'q'+QuestiondId-Points-PointType, ..."
            string pointsString = (string) Session["points"];
            string[] pointsArray = pointsString.Split(',');

            List<List<float>> typeArrays = new List<List<float>>();

            for (int i = 0; i < count; i++)
            {
                typeArrays.Add(new List<float>());
            }

            foreach (string pointS in pointsArray)
            {
                #region Split String

                //Array with details of the questionId, number of points, & Point type
                var pointDet = pointS.Split('-');

                //Question ID = "q102" - Converted to int - 102
                int qId = 0;
                Int32.TryParse(pointDet.GetValue(0).ToString().Substring(1), out qId);

                //Points = "1" - Converted to int - 1
                int points = 0;
                Int32.TryParse(pointDet.GetValue(1).ToString(), out points);

                //Point Type = "need" / "qualification"
                string pointType = pointDet.GetValue(2).ToString();

                #endregion

                StringTypeSwitch(() =>
                {
                    typeArrays[0].Add((float)points);
                }, () =>
                {
                    typeArrays[1].Add((float)points);
                }, pointType);
            }

            return typeArrays;
        }

        //Count - Number of point types (Need, qualification) - 2
        private List<Array> MaxPointsPerType(int count)
        {
            QuestionsContainer qCont = new QuestionsContainer();
            var all = qCont.GetAllQuestions();

            List<Array> maxMinArray = new List<Array>();

            for (int i = 0; i < count; i++)
            {
                //Max,Min value
                maxMinArray.Add(new int[] {0, 0});
            }
            
            //Gets the max and min value point for a single answer in each point type
            //e.g. for "need" = {5,0}, for "qualification" = {6,-20}
            foreach (Question q in all)
            {
                foreach (int point in q.Points)
                {
                    //Switch method - switch cases at the bottom
                    StringTypeSwitch(() =>
                    {
                        maxMinArray[0] = SwitchType((int[])maxMinArray[0], point, (int)maxMinArray[0].GetValue(0), (int)maxMinArray[0].GetValue(1));
                    }, () =>
                    {
                        maxMinArray[1] = SwitchType((int[])maxMinArray[1], point, (int)maxMinArray[1].GetValue(0), (int)maxMinArray[1].GetValue(1));
                    }, q.PointType);
                }
            }

            return maxMinArray;
        }

        private int[] SwitchType(int[] maxMin, int point, int max, int min)
        {
            if (point > max)
            {
                maxMin[0] = point;
            } else if (point < min)
            {
                maxMin[1] = point;
            }

            return maxMin;
        }

        private void StringTypeSwitch(Action need, Action qualification, string switchCheck)
        {
            switch (switchCheck)
            {
                case "need":
                    need();
                    break;
                case "qualification":
                    qualification();
                    break;
            }
        }
    }
}