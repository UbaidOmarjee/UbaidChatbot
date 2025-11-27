using System.Net.Http;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace ChatBotMVC.Services
{
    public class AiChatService
    {
        private readonly string _apiKey;
        private readonly HttpClient _http;

        public AiChatService(IConfiguration config)
        {
            _apiKey = Environment.GetEnvironmentVariable("GROQ_API_KEY");

            _http = new HttpClient();
        }

        public async Task<string> AskAsync(string userMessage)
        {
            string url = "https://api.groq.com/openai/v1/chat/completions";

            var body = new
            {
                model = "openai/gpt-oss-120b",
                // free, powerful
                messages = new[]
                {
                    new { role = "system", content = "Always respond in clean plain text. Do not use Markdown, bold text, lists, tables, bullet points, or formatting." },

    new { role = "user", content = userMessage }
                }
            };

            var content = new StringContent(
                JsonSerializer.Serialize(body),
                Encoding.UTF8,
                "application/json"
            );

            _http.DefaultRequestHeaders.Clear();
            _http.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");

            var response = await _http.PostAsync(url, content);
            var json = await response.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(json);

            // catch errors
            if (doc.RootElement.TryGetProperty("error", out JsonElement err))
            {
                return "Groq Error: " + err.GetProperty("message").GetString();
            }

            return doc.RootElement
                .GetProperty("choices")[0]
                .GetProperty("message")
                .GetProperty("content")
                .GetString();
        }
    }
}
