using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class Game
    {
        bool willPlay = false;
        private int score = 0;
        private int roundNumber = 1;

        public void gamePrompt()
        {
            string promptText = "Do you want to play a quiz? (Y/N)";
            Console.WriteLine(promptText);

            while (willPlay == false)
            {

                string userAnswer = Console.ReadLine().ToLower();

                if (userAnswer == "y")
                {
                    willPlay = true;
                }
                else if (userAnswer == "n")
                {
                    Console.WriteLine(promptText);
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Console.WriteLine(promptText);
                }
            }

        }
        public void askQuestion(string questionPrompt, string answerOne, string answerTwo, string answerThree)
        {
            Console.WriteLine($"Round {roundNumber}: {questionPrompt} - Possible Answers:");
            Console.WriteLine(answerOne);
            Console.WriteLine(answerTwo);
            Console.WriteLine(answerThree);
            Console.WriteLine("Please enter A, B or C.");

        }

        public void playRound(string correctAnswer)
        {
            string userAnswer = Console.ReadLine().ToLower();

            while (userAnswer != "a" && userAnswer != "b" && userAnswer != "c")
            {
                Console.WriteLine("Please Enter A, B or C");
                userAnswer = Console.ReadLine().ToLower();
            }

            if (userAnswer == correctAnswer[..1].ToLower()) {
                score++;
                Console.WriteLine("Correct");
            } else {
                Console.WriteLine("Incorrect");
            }

            Console.WriteLine($"Your current score is {score} out of {roundNumber}!");
            roundNumber++;
        }

        public void gameEnd()
        {
            switch (score)
            {
                case 0:
                    Console.WriteLine("Terrible Score, try again!");
                    break;
                case 1:
                    Console.WriteLine("Much room for improvement!");
                    break;
                case 2:
                    Console.WriteLine("Decent score!");
                    break;
                case 3:
                    Console.WriteLine("Perfect Score!");
                    break;
                default:
                    Console.WriteLine("Something is broken!");
                    break;
            }
        }


    }
}
