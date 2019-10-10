using System;
using System.Collections.Generic;
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

        public string Label { get; set; }
        public string Value { get; set; }
    }
}