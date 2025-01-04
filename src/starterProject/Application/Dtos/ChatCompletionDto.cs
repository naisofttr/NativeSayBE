namespace Application.Dtos;
public class ChatCompletionDto
{
    //    public string Id { get; set; }
    //    public string Object { get; set; }
    //    public long Created { get; set; }
    //    public string Model { get; set; }
    public List<Choice> Choices { get; set; }
    //public Usage Usage { get; set; }
    //public object SystemFingerprint { get; set; }
}

public class Choice
{
    //public int Index { get; set; }
    public Message Message { get; set; }
    //public object Logprobs { get; set; }
    //public string FinishReason { get; set; }
}

public class Message
{
    //public string Role { get; set; }
    public string Content { get; set; }
    //public object Refusal { get; set; }
}

//public class Usage
//{
//    public int PromptTokens { get; set; }
//    public int CompletionTokens { get; set; }
//    public int TotalTokens { get; set; }
//    public TokenDetails PromptTokensDetails { get; set; }
//    public TokenDetails CompletionTokensDetails { get; set; }
//}

//public class TokenDetails
//{
//    public int CachedTokens { get; set; }
//    public int AudioTokens { get; set; }
//    public int ReasoningTokens { get; set; }
//    public int AcceptedPredictionTokens { get; set; }
//    public int RejectedPredictionTokens { get; set; }
//}

