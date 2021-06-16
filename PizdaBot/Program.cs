using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace PizdaBot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var token = await System.IO.File.ReadAllTextAsync("token.txt");
            var client = new TelegramBotClient(token);
            client.OnMessage += (_, ea) =>
            {
                try
                {
                    if (ea.Message.Text.ToLowerInvariant() == "да")
                        client.SendStickerAsync(ea.Message.Chat, new InputMedia("CAACAgIAAxkBAAMsYMndSbtmS8jFrKeWzcpHj8PCHDwAAgIAA8rM2SfczZz_qtrYGh8E"));

                    if (ea.Message.Text.ToLowerInvariant() == "нет")
                        client.SendTextMessageAsync(ea.Message.Chat, "Минет.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                
            };
            client.StartReceiving();
            await Task.Delay(Timeout.InfiniteTimeSpan);
        }
    }
}