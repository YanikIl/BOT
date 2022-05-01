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

namespace BLL
{
    public abstract class AbstractQuestion
    {
        public string Name { get; set; }
        public List<string> Options { get; set; }
        public string Answer { get; set; }

        //public abstract AbstractQuestion Clone();

        //public abstract IReplyMarkup GetMarkup();

        //public abstract bool SetAnswer(string message);
    }
}