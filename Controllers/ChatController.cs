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
            // Start a fresh chat
            return View(new ChatMessage());
        }

        [HttpPost]
        public async Task<IActionResult> Index(ChatMessage model)
        {
            // Add USER message
            model.ChatHistory.Add(new ChatHistoryItem
            {
                Message = model.UserMessage,
                IsUser = true
            });

            // Ask bot
            var reply = await _ai.AskAsync(model.UserMessage);

            // Add BOT message
            model.ChatHistory.Add(new ChatHistoryItem
            {
                Message = reply,
                IsUser = false
            });

            // Clear input
            model.UserMessage = string.Empty;

            return View(model);
        }

    }
}
