namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Quiz newQuiz = new(setQuestion: "Q1", setAnswer: "A");
        }

    class Quiz
        {
            public string? AskQuestion;
            public string? CorrectAnswer;

            public void Question(string setQuestion, string setAnswer)
            {
                AskQuestion = setQuestion;
                CorrectAnswer = setAnswer;

            }
        }
      
    }
}