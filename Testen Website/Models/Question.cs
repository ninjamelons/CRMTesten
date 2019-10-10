using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Testen_Website.Models
{
    public class Question
    {
        //If points are different depending on the answer
        public Question(int qId, string question, string inputType, Array answers, Array points)
        {
            QuestionId = qId;
            QuestionValue = question;
            InputType = inputType;
            Answers = answers;
            Points = points;

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
    }

    public class QuestionRep
    {
        //If points are different depending on the answer
        public QuestionRep(int qId, string inputType, string question, List<Answer> answers)
        {
            ID = qId;
            InputType = inputType;
            Value = question;
            Answers = answers;
        }

        public int ID { get; set; }
        public string InputType { get; set; }
        public string Value { get; set; }
        public List<Answer> Answers { get; set; }
    }
}