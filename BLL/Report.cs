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
    public class Report
    {
        public string Group { get; set; }
        public string User { get; set; }
        public string Test { get; set; }
        public List<string> Answers { get; set; }

        public Report()
        {

        }
    }
}
