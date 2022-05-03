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
        private Test _test;
        //private Action<string> _user;

        Dictionary<long, TestsPassController> Tests { get; set; } = Storage.Tests;


        public TelegramManager(string token, Action<string> onMessage, Test test )// Group group)
        {
            _client =new TelegramBotClient(token);
            _onMessage = onMessage;
            _test = test;
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
                string send = update.Message.Chat.FirstName + " " + update.Message.Chat.LastName + ": " + update.Message.Text;
                _onMessage(send);
            }
            //string user = update.Message.Chat.FirstName;

            long chatId = update.Message.Chat.Id;

            if (!Tests.ContainsKey(chatId))
            {
                Tests.Add(
                    chatId,
                    new TestsPassController(update.Message.Chat, _test)
                    );

                var crntTest = Tests[chatId];
                SendNextQuestion(crntTest);

            }
            else if (Tests.ContainsKey(chatId) && Tests[chatId].QuestionIndex <= Tests[chatId].Test.questions.Count - 1)
            {
                var crntTest = Tests[chatId];

                if (crntTest.Test.questions[crntTest.QuestionIndex].SetAnswer(update.Message.Text))
                {
                    crntTest.QuestionIndex++;
                }

                if (Tests[chatId].QuestionIndex <= Tests[chatId].Test.questions.Count - 1)
                {
                    SendNextQuestion(crntTest);
                }
            }
            else
            {
                _client.SendTextMessageAsync(Tests[chatId].Chat.Id, "Ok. If you say so. Bye.");

            }
        }

        private Task HandleError(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {

            return Task.CompletedTask;
        }

        private void SendNextQuestion(TestsPassController i)
        {
            _client.SendTextMessageAsync(
                    i.Chat.Id,
                    i.Test.questions[i.QuestionIndex].Name,
                    replyMarkup: i.Test.questions[i.QuestionIndex].GetMarkup()
                    );
        }
    }
}
