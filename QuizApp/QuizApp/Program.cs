
namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Destructure this into my Class
            string[] questionOneProperties = { "Q1", "A", "B", "C" }; 

            Questions questionOne = new Questions("Q 1", "A1", "A2", "A3", 1);




            for (int x = 0; x < questionOneProperties.Length; x++)
            {
                Console.WriteLine(questionOne.CorrectAnswer);

            }
            //Console.WriteLine(questionOne.Question + " " + questionOne.Answer);

            /*
            bool willPlay = false;
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

            int winCount = 0;
            string[] answer = {"a", "b", "c" };

            Console.WriteLine("Question 1: A/B/C - (Hint: A)");
            string answerOne = Console.ReadLine().ToLower();
            if (answer[0] == answerOne) {
                winCount++;
                Console.WriteLine("Correct! Your Score is: " + winCount);
            } else {
                Console.WriteLine("False! Your Score is: " + winCount);
            }

            Console.WriteLine("Question 2: A/B/C - (Hint: B)");
            string answerTwo = Console.ReadLine().ToLower();
            if (answer[1] == answerTwo)
            {
                winCount++;
                Console.WriteLine("Correct! Your Score is: " + winCount);
            }
            else
            {
                Console.WriteLine("False! Your Score is: " + winCount);
            }

            Console.WriteLine("Question 1: A/B/C - (Hint: C)");
            string answerThree = Console.ReadLine().ToLower();
            if (answer[2] == answerThree)
            {
                winCount++;
                Console.WriteLine("Correct! Your Score is: " + winCount);
            }
            else
            {
                Console.WriteLine("False! Your Score is: " + winCount);
            }


            Console.WriteLine("Complete! Your Total score was: " + winCount);
            */

        }
    }

}