using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;

namespace QnAMakerQuickStart
{
    static class RequestQnAMaker
    {
        static string uri = @"QnA Maker uri";
        static string endpointKey = @"EndpointKey";

        async public static Task<string> SendQuestion(string question)
        {

            using (HttpClient client = new HttpClient())
            using (HttpRequestMessage request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;

                var questionObj = new { question = question };
                request.Content = new StringContent(JsonConvert.SerializeObject(questionObj), Encoding.UTF8, "application/json");

                request.RequestUri = new Uri(uri);
                request.Headers.Add("Authorization", endpointKey);

                var response = await client.SendAsync(request);
                var responseInJson = await response.Content.ReadAsStringAsync();

                return responseInJson;
            }
        }

        public static string GetAnAnswer(string responseInJson)
        {
            KnowledgeBase response = JsonConvert.DeserializeObject<KnowledgeBase>(responseInJson);
            string answer = response.Answers[0].Answer;

            if (answer == "No good match found in KB.")
            {
                return "I have no answer to your question. Please correct your question.";
            }
            return answer;
        }
    }
}
