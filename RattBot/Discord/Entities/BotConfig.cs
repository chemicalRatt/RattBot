using Discord.WebSocket;

namespace RattBot.Discord.Entities
{
    class BotConfig
    {
        public string Token { get; set; }
        public DiscordSocketConfig SocketConfig { get; set; }
    }
}
