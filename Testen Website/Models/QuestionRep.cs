using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        //Question ID - used to group answers together, and possible results/database storage
        [Description("ID used to group answers/Store results in database")]
        public int ID { get; set; }
        [Description("Type of input for answers e.g. checkbox")]
        public string InputType { get; set; }
        [Description("Question to be shown on the label")]
        public string Value { get; set; }
        [Description("List of possible answers")]
        public List<Answer> Answers { get; set; }
    }
}