public class ChatMessage
{
    public string UserMessage { get; set; }
    public string BotResponse { get; set; }

    public List<ChatHistoryItem> ChatHistory { get; set; } = new();


}

public class ChatHistoryItem
{
    public string Message { get; set; }
    public bool IsUser { get; set; }
}

