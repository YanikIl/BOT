﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Questions
{
    public class RadioButtonQuestion: AbstractQuestion
    {
        private bool _isYes;
        public bool IsYes
        {
            get { return _isYes; }
            set { _isYes = value; }
        }
        public List<string> AnswerOptions;
        public RadioButtonQuestion(string name)
        {
            Name = name;
            Type = "Radio button question";
        }
        public override List<string> GetAnswer()
        {
            return AnswerOptions;
        }


    }
}
