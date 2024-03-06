using AspNetCoreWebApi.Configurations;
using AspNetCoreWebApi.Interfaces;
using Microsoft.Extensions.Options;

namespace AspNetCoreWebApi.Services
{
    public class OpenAiService : IOpenAiService
    {
        private readonly OpenAiConfig _openAiConfig;
        public OpenAiService(IOptionsMonitor<OpenAiConfig> optionsMonitor)
        {
            _openAiConfig = optionsMonitor.CurrentValue;
        }
        public async Task<string> CompleteSentence(string text)
        {
            // APi intance
            var api = new OpenAI_API.OpenAIAPI(_openAiConfig.OpenAISecretKey);
            var result = await api.Completions.GetCompletion(text);
            return result;
        }
    }
}
