using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Testen_Website.Models
{
    public class Question
    {
        //If points are different depending on the answer
        public Question(int qId, string question, string inputType, Array answers, Array points, string pointType)
        {
            QuestionId = qId;
            QuestionValue = question;
            InputType = inputType;
            Answers = answers;
            Points = points;
            PointType = pointType;

            if (Points.Length != Answers.Length)
            {
                throw new Exception("Points array length different from Answers array length");
            }
        }

        public int QuestionId { get; set; }
        public string QuestionValue { get; set; }
        public string InputType { get; set; }
        public Array Answers { get; set; }
        public Array Points { get; set; }
        public string PointType { get; set; }
    }
}