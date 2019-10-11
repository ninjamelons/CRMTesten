using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Testen_Website.Models
{
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