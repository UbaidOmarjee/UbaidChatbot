# 🤖 AI ChatBot MVC Prototype  
*A modern AI-powered chatbot built using ASP.NET Core MVC, Groq API, and a custom elegant UI.*

---

## 📄 Overview  
This project is a **prototype AI chatbot** developed for portfolio and resume purposes.  
It demonstrates:

- Full-stack ASP.NET Core MVC development  
- Integration with real AI models through the **Groq API**  
- Custom UI/UX with multiple themes (Dark, Light, Neon)  
- Modern chat animations and message flow  
- Mobile-responsive design  
- Conversation memory support  
- New Chat session handling  

Although lightweight, the project showcases practical skills needed to build real-world AI interfaces similar to ChatGPT.

---

## 🚀 Features  

### 💬 **AI Messaging System**
- Send messages to the chatbot and receive intelligent responses.
- Uses **Groq’s model** (free + fast).
- Supports **conversation history context**.

### 🎨 **Elegant Custom UI**
- Fully redesigned **polytheme.css** with:
  - Smooth bubble animations  
  - Clean layout  
  - Centered chat interface  
  - Avatar icons for bot & user  
  - Better spacing and readability  

### 🌓 **Multiple Themes**
Users can switch between:
- Dark Theme  
- Light Theme (ChatGPT style)  
- Neon Theme  
- Future Blue Theme  

### 📱 **Mobile Responsive**
- Optimized for all screen sizes  
- Input bar behaves correctly on mobile  
- Scrolling and layout adapt automatically  

### 🆕 **New Chat System**
- “New Chat” button resets conversation  
- Behaves similarly to ChatGPT’s new chat workflow  

### 🔧 **Backend Architecture**
- ASP.NET Core MVC  
- Strong separation of concerns  
- `AiChatService` handles all AI requests  
- Powered by HttpClient + JSON serialization  

---

## 🛠️ Technologies Used

| Layer          | Technology |
|----------------|------------|
| Frontend       | HTML, Razor, CSS3, custom animations |
| Backend        | ASP.NET Core MVC (.NET 8) |
| AI Model       | Groq `gpt-oss-120b` |
| Deployment     | Render (Dockerized) |
| Version Control| Git & GitHub |

---

## 🏗️ Deployment (Render)
The project includes a **Dockerfile** for easy hosting:

- Build project  
- Publish for production  
- Run with Kestrel  

This allows running the chatbot online with zero server configuration.

---

## 🎯 Purpose of This Project
This chatbot prototype was built for:

- **Portfolio demonstration**
- **Resume showcasing**
- **Practicing full-stack ASP.NET development**
- **Demonstrating AI integration experience**
- **UI/UX styling and theme systems**

It is intentionally lightweight but production-style in structure and design.

---

## 🔮 Future Improvements
Potential extensions include:

- User authentication (Google OAuth)  
- Saved chat history per user  
- Profile system  
- Streaming responses (typing effect like ChatGPT)  
- File upload → AI analysis  
- Voice input + voice reply  

---

## 👤 Author
**Ubaid Omarjee**  
 ASP.NET Full-Stack Developer
 
---

## 📌 License
This project is a prototype and is free for educational and portfolio use.
