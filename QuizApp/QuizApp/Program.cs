
namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] questionOneProps = { "What colour are cabbies in London?", "A: Black", "B: Blue", "C: Beige", "A" };
            string[] questionTwoProps = { "Which equation is the greatest?", "A: 50 + 50", "B: 1000 + -1000", "C: 50 / 0.1", "C" };
            string[] questionThreeProps = { "Which planet is the smallest?", "A: Pluto", "B: Mercury", "C: Venus", "B" };

            Question questionOne = new(questionOneProps);
            Question questionTwo = new(questionTwoProps);
            Question questionThree = new(questionThreeProps);

            Game Quiz = new();

            Quiz.gamePrompt();

            Quiz.askQuestion(questionOne.questionPrompt, questionOne.answerOne, questionOne.answerTwo, questionOne.answerThree);
            Quiz.playRound(questionOne.correctAnswer);

            Quiz.askQuestion(questionTwo.questionPrompt, questionTwo.answerOne, questionTwo.answerTwo, questionTwo.answerThree);
            Quiz.playRound(questionOne.correctAnswer);

            Quiz.askQuestion(questionThree.questionPrompt, questionThree.answerOne, questionThree.answerTwo, questionThree.answerThree);
            Quiz.playRound(questionThree.correctAnswer);

            Quiz.gameEnd();




        }
    }

}