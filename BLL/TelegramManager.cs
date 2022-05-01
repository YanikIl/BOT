using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace BLL
{
    public class TelegramManager
    {
        private TelegramBotClient _client;
        private Action<string> _onMessage;
        //private Action<string> _user;


        public TelegramManager(string token, Action<string> onMessage )// Action<string> user)
        {
            _client =new TelegramBotClient(token);
            _onMessage = onMessage;
            //_user = user;
        }

        public void Start()
        {
            _client.StartReceiving( HandleResive, HandleError);
        }
        private async Task HandleResive(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Message != null && update.Message.Text != null)
            {
                string send = update.Message.Text;
                _onMessage(send);
            }
            //string user = update.Message.Chat.FirstName;

        }

        private Task HandleError(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {

            return Task.CompletedTask;
        }
    }
}
