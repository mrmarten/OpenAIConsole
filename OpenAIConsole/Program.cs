using System;
using OpenAI_API;

namespace OpenAIConsole
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("sk-Calling API");
            var api = new OpenAI_API.OpenAIAPI(new APIAuthentication("sk-"),engine: Engine.Davinci);
;

            var result = await api.Completions.CreateCompletionAsync("how many people live on earth?");
            Console.WriteLine(result.ToString());
            // should print something that starts with "Three"
        }
    }
}
