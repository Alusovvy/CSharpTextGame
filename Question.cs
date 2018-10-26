using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantsToBeAMillionare
{
    public class Question
    {
        public int id { get; set; }
        public string QuestionContent { get; set; }
        public string Answers { get; set; }
        public string CorrectAnswer { get; set; }

        public Question(int ID, string questionContent, string answers, string correctAnswer)
        {
            this.id = ID;
            this.QuestionContent = questionContent;
            this.Answers = answers;
            this.CorrectAnswer = correctAnswer;



        }
    }
}
