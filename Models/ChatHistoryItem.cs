namespace ChatWithLLM.Models
{
    public class ChatHistoryItem
    {
        public string UserMessage { get; set; }
        public string AiResponse { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
