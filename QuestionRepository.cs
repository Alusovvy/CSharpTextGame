using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantsToBeAMillionare
{
   public class QuestionRepository
    {
        public void QuestionTemplate()
        {
            bool AnswerIsCorrect = true;
            int x = 0;
            int CorretAnswers = 0;
            while (AnswerIsCorrect == true)
            {
                TemporaryQuestionBase QuestionFilling = new TemporaryQuestionBase();
                Question question = new Question(QuestionFilling.id[0 + x], QuestionFilling.QuestionContent[0 + x], QuestionFilling.Answers[0 + x], QuestionFilling.CorrectAnswer[0 + x]);
                Console.WriteLine("Question number = " + x);
                Console.WriteLine(question.QuestionContent);
                Console.WriteLine(question.Answers);
                string answer = Console.ReadLine();
                if (!answer.Equals(question.CorrectAnswer))
                {
                    AnswerIsCorrect = false;
                    Console.WriteLine("Answer was incorrect. Remember to put only a single capital letter as an answer (e. g. A)");
                }
                Random random = new Random();
                x = random.Next(1, 15);
                CorretAnswers++;
                if (CorretAnswers >= 15)
                {
                    Console.WriteLine("Wygrałeś miliona!");
                    AnswerIsCorrect = false;
                }
                Console.ReadKey();
            }
        }
        
       
    }
}
