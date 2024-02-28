using Pico.Twitch;

namespace TwitchBot
{

    class Program
    {

        static string oauth = [YOUR_OAUTH_TOKEN];
        static string channelName = [YOUR_CHANNEL_NAME_TO_JOIN];
        
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
