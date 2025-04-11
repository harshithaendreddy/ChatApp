## 💬 ASP.NET Core Chat Application

A simple chat web application built using **ASP.NET Core MVC (.NET 8)**. It allows users to log in with a username, send messages, and view a shared chat log. The app uses **session state** to maintain user identity and a **singleton service** to manage chat messages in memory across requests.

---

### 🚀 Features

- ✅ User login with session storage  
- ✅ Chat page for sending messages  
- ✅ Display page for viewing chat history  
- ✅ Application-wide message storage using `IHostedService` or `Singleton Service`  
- 🔐 Basic validation for empty usernames and messages  
- 📂 MVC architecture with Razor views  

---

### 🛠️ Technologies Used

- ASP.NET Core MVC (.NET 8)
- Razor Pages
- Session State
- Dependency Injection (Singleton)
- C#
- HTML & minimal CSS

---

### 📁 Project Structure

```
/Controllers
  HomeController.cs         // Handles login
  ChatController.cs         // Handles chat and display logic

/Models
  ChatMessageStore.cs       // Singleton service for storing messages

/Views
  /Login
    Index.cshtml            // Login form
  /Chat
    Chat.cshtml             // Chat message input
    Display.cshtml          // Displays all chat messages

Startup Configuration (Program.cs)
```

---

### 🧪 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/chat-app-aspnet.git
   cd chat-app-aspnet
   ```

2. Open the solution in **Visual Studio 2022/2023**

3. Make sure **.NET 8 SDK** is installed

4. Run the app using IIS Express or `dotnet run`
