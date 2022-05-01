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
    public class OpenQuestion: AbstractQuestion
    {
        
        public OpenQuestion(string name)
        {
            Name = name;
            Options = null;
            Answer = null;
        }
        
        //public override AbstractQuestion Clone()
        //{
        //    List<string> list = new List<string>();
        //    foreach (var item in Options)
        //    {
        //        list.Add(item.ToString());
        //    }
        //    return new OpenQuestion(this.Name)
        //    {
        //        Answer = this.Answer,
        //        Name = this.Name,
        //        Options = list
        //    };
        //}

        //public override IReplyMarkup GetMarkup()
        //{
        //    return null;
        //}

        //public override bool SetAnswer(string message)
        //{
        //    message.Trim();
        //    Answer = message;
        //    return true;
        //}

    }
}
