using System;
using System.Threading.Tasks;
using RattBot.Discord;
using RattBot.Discord.Entities;
using RattBot.storage;

namespace RattBot
{
    internal class Program
    {
        private static async Task Main()
        {
            Console.WriteLine("Hello world");
            

            Unity.RegisterTypes();
            var storage = Unity.Resolve<IDataStorage>();
            var connection = Unity.Resolve<Connection>();
            await connection.ConnectAsync(new BotConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });
            Console.ReadKey();
        }
    }       
}
