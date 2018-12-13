using System;
using RattBot.Discord;
using RattBot.Discord.Entities;

namespace RattBot
{
    internal class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();
            var botConfig = new BotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };
        }
    }       
}
