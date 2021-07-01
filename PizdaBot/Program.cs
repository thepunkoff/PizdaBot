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
            TelegramBotClient client = null;
            try
            {
                var token = await System.IO.File.ReadAllTextAsync("token.txt");
                token = token.Replace("\r", string.Empty);
                token = token.Replace("\n", string.Empty);
                Console.WriteLine(token);
                client = new TelegramBotClient(token);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }

            client.OnMessage += (_, ea) =>
            {
                Console.WriteLine($"New message: {ea.Message.Text ?? "null"}");
                try
                {
                    if (ea.Message.Text is null)
                        return;

                    if (Helper.IsDa(ea.Message.ToString()))
                    {
                        Console.WriteLine("Sending kirkorov");
                        client.SendStickerAsync(ea.Message.Chat, new InputMedia("CAACAgIAAxkBAAMsYMndSbtmS8jFrKeWzcpHj8PCHDwAAgIAA8rM2SfczZz_qtrYGh8E"));
                    }

                    if (Helper.IsNet(ea.Message.ToString()))
                    {
                        Console.WriteLine("Sending blowjob");
                        client.SendTextMessageAsync(ea.Message.Chat, "Минет.");
                    }
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