using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Testen_Website.Questions
{
    public class HtmlEmailFormatter
    {
        public static string GetHtmlFile(string result)
        {
            var htmlAsString = File.ReadAllText("/Content/HtmlEmail.html");
            var text = ResultSwitch(result);

            var formattedString = String.Format(htmlAsString, text[0], text[1], text[2], text[3]);

            return formattedString;
        }

        private static string[] ResultSwitch(string result)
        {
            string[] arr = {"","","",""};

            switch (result)
            {
                case "360":
                    arr[0] = "360 Business Tool";
                    arr[1] = "Something  seot";
                    arr[2] = "Something  seot";
                    arr[3] = "Something  seot";
                    break;
                case "small":
                    arr[0] = "360 Business Tool";
                    arr[1] = "Something  seot";
                    arr[2] = "Something  seot";
                    arr[3] = "Something  seot";
                    break;
                case "big":
                    arr[0] = "360 Business Tool";
                    arr[1] = "Something  seot";
                    arr[2] = "Something  seot";
                    arr[3] = "Something  seot";
                    break;
            }

            return arr;
        }
    }
}