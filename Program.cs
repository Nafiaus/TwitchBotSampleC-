using Pico.Twitch;

namespace TwitchBot
{

    class Program
    {

        static string oauth = "oauth:yevs6k8g77wgrl9j62788olkc56ozm";
        static string channelName = "nafiaus";
        
        static TwitchChatHandle chat = new TwitchChatHandle(oauth, channelName);
        static void Main(string[] args)
        {
            while (true)
            {
                var chatEntry = chat.Read();
                CheckCommand(chatEntry);

            }
        }

        static void CheckCommand(TwitchChatEntry chatEntry)
        {
            string msg = chatEntry.Message;
            switch(msg)
            {
                case "!hello":
                    chat.Write("Hello World");
                    break;
            }
        }
    }
}