using Newtonsoft.Json;

namespace QnAMakerQuickStart
{
    public class KnowledgeBase
    {
        [JsonProperty("answers")]
        public Answers[] Answers;
    }
    public class Answers
    {
        [JsonProperty("questions")]
        public string[] Questions;

        [JsonProperty("answer")]
        public string Answer { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("id")]
        public  int Id { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("metadata")]
        public string[] Metadata { get; set; }
    }
}