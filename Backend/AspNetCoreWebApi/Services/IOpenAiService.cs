namespace AspNetCoreWebApi.Interfaces
{
    public interface IOpenAiService
    {
        Task<string> CompleteSentence(string text);
    }
}
