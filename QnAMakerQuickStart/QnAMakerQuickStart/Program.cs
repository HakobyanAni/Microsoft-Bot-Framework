using System;
using System.Threading.Tasks;

namespace QnAMakerQuickStart
{
    class Program
    {
        // This example is only to show how to deal with QnA Maker. You can put this example into the bot, 
        // give configurtions and work with it.
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string question = Console.ReadLine();

            Task<string> sendQuestion = RequestQnAMaker.SendQuestion(question);
            string response = sendQuestion.Result;

            string answer = RequestQnAMaker.GetAnAnswer(response);

            Console.WriteLine(answer);

            Console.ReadKey();
        }
    }
}