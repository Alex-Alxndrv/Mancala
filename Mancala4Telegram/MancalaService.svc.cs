using System.Configuration;
using Telegram.Bot.Types.ReplyMarkups;

namespace Mancala4Telegram
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MancalaService : IMancalaService
    {
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}

        public void GetUpdate(Update update)
        {
            log.InfoFormat("{0}:{1}", update.message.from.username, update.message.text);

            var Bot = new Telegram.Bot.TelegramBotClient(ConfigurationManager.AppSettings["telegramToken"]);
                        
            if (update.message.text != null)
            {
                switch (update.message.text.ToLower())
                {
                    case "привет":
                        Bot.SendTextMessageAsync(update.message.chat.id, "Привет," + update.message.from.first_name);
                        break;
                    case "/newgame":
                        ReplyKeyboardMarkup replyKeyboardMarkup =
                            new ReplyKeyboardMarkup(
                                new[]
                                {
                                    new Telegram.Bot.Types.KeyboardButton("1"),
                                    new Telegram.Bot.Types.KeyboardButton("2"),
                                    new Telegram.Bot.Types.KeyboardButton("3"),
                                    new Telegram.Bot.Types.KeyboardButton("4"),
                                    new Telegram.Bot.Types.KeyboardButton("5"),
                                    new Telegram.Bot.Types.KeyboardButton("6")
                                });

                        Bot.SendTextMessageAsync(update.message.chat.id, "————————————————", Telegram.Bot.Types.Enums.ParseMode.Markdown, true, true, 0, replyKeyboardMarkup);

                        break;

                    case "гад":
                    case "гандон":
                    case "гнида":
                    case "гавно":
                    case "говнище":
                    case "говно":
                    case "говнюк":
                    case "гондон":
                    case "дерьмо":
                    case "долбоеб":
                    case "долбоёб":
                    case "ебан":
                    case "ебанат":
                    case "ебанашка":
                    case "ебанутый":
                    case "ёбнутый":
                    case "жлоб":
                    case "жопа":
                    case "жопошник":
                    case "заебал":
                    case "засранец":
                    case "идиот":
                    case "мудак":
                    case "мудозвон":
                    case "негодяй":
                    case "обмудок":
                    case "падла":
                    case "педик":
                    case "педрила":
                    case "петушара":
                    case "пидор":
                    case "пидорас":
                    case "пидрила":
                    case "поебень":
                    case "сучара":
                    case "сучка":
                    case "ублюдок":
                    case "уёба":
                    case "уёбок":
                    case "хуесос":
                    case "хуила":
                    case "чмо":
                    case "чмошник":
                        Bot.SendTextMessageAsync(update.message.chat.id, "Пошёл нахуй, " + update.message.from.first_name);
                        break;
                    


                    default:
                        break;
                }
            }
        
        
        }
    }
}
