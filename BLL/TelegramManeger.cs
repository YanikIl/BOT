using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace BLL
{
    internal class TelegramManeger
    {
        private TelegramBotClient _client;
        private Action<string> _onMessage;
        private List<long> _ids;

        public TelegramManeger(string token, Action<string> onMessage)
        {
            _client = new TelegramBotClient(token);
            _onMessage = onMessage;
            _ids = new List<long>();
        }

        

        public void Start()
        {
            _client.StartReceiving(HandleResive, HandleError);
        }

        private async Task HandleResive(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {



            if (update.Message != null && update.Message.Text != null)
            {

                if (!_ids.Contains(update.Message.Chat.Id))
                {
                    _ids.Add(update.Message.Chat.Id);
                }

                string s = update.Message.Chat.FirstName + " "
                    + update.Message.Chat.LastName + " "
                    + update.Message.Text;
                _onMessage(s);

                if (!Storage.DataBase.ContainsKey(update.Message.Chat.Id))
                {
                    Storage.DataBase.Add(update.Message.Chat.Id, new User() { Chat = update.Message.Chat });
                }
            }
            else if (update.CallbackQuery != null)
            {
                
                await botClient.EditMessageTextAsync(
                    update.CallbackQuery.Message!.Chat.Id,
                    update.CallbackQuery.Message!.MessageId,
                    update.CallbackQuery.Message!.Text!,
                    replyMarkup: null
                    );


                string s = update.CallbackQuery.From.FirstName + " "
                    + update.CallbackQuery.From.LastName + " нажал на "
                    + update.CallbackQuery.Data;
                _onMessage(s);
            }

        }

        private Task HandleError(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {

            return Task.CompletedTask;
        }
    }
}
