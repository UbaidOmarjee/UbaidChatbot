using System;

namespace ChatBotMVC.Services
{
    public class ChatBotService
    {
        private readonly Random _rng = new Random();

        public string GetResponse(string message)
        {
            message = message.ToLower();

            // Basic rule-based AI
            if (message.Contains("hello") || message.Contains("hi"))
                return "Hello! How can I help you today?";

            if (message.Contains("how are you"))
                return "I'm functioning perfectly — thanks for asking!";

            if (message.Contains("your name"))
                return "I'm ChatBotMVC, built in ASP.NET Core.";

            if (message.Contains("bye"))
                return "Goodbye! It was nice chatting with you.";

            // Random fallback
            string[] randomReplies =
            {
                "Interesting… tell me more.",
                "Can you explain that differently?",
                "I’m not sure I understand, but I want to!",
                "That's cool! What else?"
            };

            return randomReplies[_rng.Next(randomReplies.Length)];
        }
    }
}
