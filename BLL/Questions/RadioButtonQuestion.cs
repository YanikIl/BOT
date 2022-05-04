using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace BLL.Questions
{
    public class RadioButtonQuestion: AbstractQuestion
    {
        public string Answer { get; set; }
        public List<string> Options { get; set; } = new List<string>();

        public RadioButtonQuestion()
        {

        }

        public RadioButtonQuestion(string name, List<string> options)
        {
            Name = name;
            Options = options;
        }

        public override IReplyMarkup GetMarkup()
        {
            ReplyKeyboardMarkup replyKeyboard = new ReplyKeyboardMarkup(
                new[]
                {
                    new[]
                    {
                        new KeyboardButton(Options[0]),
                        new KeyboardButton(Options[1])
                    },
                    new[]
                    {
                        new KeyboardButton(Options[2]),
                        new KeyboardButton(Options[3])
                    },
                }
                );

            replyKeyboard.OneTimeKeyboard = true;

            return replyKeyboard;
        }

        public override bool SetAnswer(string message)
        {
            foreach (var item in Options)
            {
                if (message == item)
                {
                    Answer = message;
                    return true;
                }
            }
            return false;
        }

    }
}
