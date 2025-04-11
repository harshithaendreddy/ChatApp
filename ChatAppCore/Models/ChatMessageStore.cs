namespace ChatAppCore.Models
{
    
    
        public class ChatMessageStore
        {
            private readonly List<string> _messages = new();

            public ChatMessageStore()
            {
                _messages.Add("Welcome to the chat room!");
            }

            public void AddMessage(string message)
            {
                _messages.Add(message);
            }

            public List<string> GetMessages()
            {
                return _messages;
            }
        }
    }


