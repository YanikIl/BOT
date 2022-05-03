using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Questions;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace BLL
{
    public class TestsPassController
    {
        public Chat Chat { get; set; }
        public Test Test { get; set; }
        public int QuestionIndex { get; set; }

        public TestsPassController(Chat chat, Test test)
        {
            Chat = chat;
            Test = TestMock.GetTestMock();
            QuestionIndex = 0;
        }
    }
}
