using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Questions
    {
        public Questions(string qInput, string aOneInput, string aTwoInput, string aThreeInput, int answer)
        {
            Question = qInput;
            AnswerOne = aOneInput;
            AnswerTwo = aTwoInput;
            AnswerThree = aThreeInput;
            CorrectAnswer = answer;
        }

        public string Question { get; set; }

        public string AnswerOne { get; set; }
        public string AnswerTwo { get; set; }
        public string AnswerThree { get; set; }
        public int CorrectAnswer { get; set; }


    }

    
}
