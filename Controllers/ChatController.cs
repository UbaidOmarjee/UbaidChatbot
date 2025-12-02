using Microsoft.AspNetCore.Mvc;
using ChatBotMVC.Models;
using ChatBotMVC.Services;

namespace ChatBotMVC.Controllers
{
    public class ChatController : Controller
    {
        private readonly AiChatService _ai;

        public ChatController(AiChatService ai)
        {
            _ai = ai;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Start empty chat
            return View(new ChatMessage());
        }

        [HttpPost]
        public async Task<IActionResult> Index(ChatMessage model)
        {
            if (!string.IsNullOrEmpty(model.UserMessage))
            {
                // 1️⃣ Add user's message to history
                model.ChatHistory.Add(new ChatHistoryItem
                {
                    Message = model.UserMessage,
                    IsUser = true
                });

                // 2️⃣ Ask AI, passing chat history for memory
                var botReply = await _ai.AskAsync(model.UserMessage, model.ChatHistory);

                // 3️⃣ Add bot response to history
                model.ChatHistory.Add(new ChatHistoryItem
                {
                    Message = botReply,
                    IsUser = false
                });

                // Clear input
                model.UserMessage = string.Empty;
            }

            return View(model);
        }
    }
}
