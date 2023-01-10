using Whetstone.ChatGPT;
using Whetstone.ChatGPT.Models;

IChatGPTClient client = new ChatGPTClient("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");

Console.WriteLine("Olá, como posso te ajudar?");

var msg = Console.ReadLine();

var gptRequest = new ChatGPTCompletionRequest
{
    Model = ChatGPTCompletionModels.Davinci,
    Prompt = msg,
    Temperature = 1,
    MaxTokens = 1024
};

var response = await client.CreateCompletionAsync(gptRequest);

Console.WriteLine(response.GetCompletionText());
Console.ReadLine();