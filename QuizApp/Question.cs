using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Question
    {
        public Question(string[] props)
        {
            questionPrompt = props[0];
            answerOne = props[1];
            answerTwo = props[2];
            answerThree = props[3];
            correctAnswer = props[4];
        }

        public string questionPrompt { get; set; }
        public string answerOne { get; set; }
        public string answerTwo { get; set; }
        public string answerThree { get; set; }
        public string correctAnswer { get; set; }


    }

    
}
