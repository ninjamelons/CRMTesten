using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Testen_Website.Models
{
    public class Answer
    {
        public Answer(string label, string value)
        {
            Label = label;
            Value = value;
        }

        [Description("Answer to be shown on the label")]
        public string Label { get; set; }
        [Description("Value from when answer is checked")]
        public string Value { get; set; }
    }
}