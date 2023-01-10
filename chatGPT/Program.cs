using Whetstone.ChatGPT;
using Whetstone.ChatGPT.Models;

//gerar chave em https://beta.openai.com/account/api-keys
IChatGPTClient client = new ChatGPTClient("CHAVE GERADA AQUI"); 


while (true)
{
    Console.WriteLine("Digite sua pergunta.");
    Console.WriteLine();
    var msg = Console.ReadLine();

    var gptRequest = new ChatGPTCompletionRequest
    {
        Model = "text-davinci-003",
        Prompt = msg,
        Temperature = 1,
        MaxTokens = 1024
    };

    var response = await client.CreateCompletionAsync(gptRequest);

    Console.WriteLine(response.GetCompletionText());
    Console.WriteLine();
}