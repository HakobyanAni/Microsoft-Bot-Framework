using System;
using System.Threading.Tasks;

namespace QnAMakerQuickStart
{
    class Program
    {
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