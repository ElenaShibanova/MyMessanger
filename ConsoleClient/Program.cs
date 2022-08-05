using System;
using Newtonsoft.Json;

namespace MyMessanger
{
    class Program
    {
        private static int MessageID;
        private static string UserName;
        private static MessangerClientAPI API = new MessangerClientAPI();

        private static void GetNewMessage() 
        {
            Message msg = API.GetMessage(MessageID);
            while (msg != null) {
                Console.WriteLine(msg);
                MessageID++;
                msg = API.GetMessage(MessageID);
            }
        }
        static void Main(string[] args)
        {
            //Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);
            //string output = JsonConvert.SerializeObject(msg);
            //Console.WriteLine(output);
            //Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            //Console.WriteLine(deserializedMsg);
            //{ "UserName":"RusAl","MessageText":"Privet","TimeStamp":"2022-07-13T11:34:20.1686757Z"}
            //RusAl < 13.07.2022 11:34:20 >:Privet
            MessageID = 1;
            Console.WriteLine("Введите Ваше имя: ");
            UserName = Console.ReadLine();
            string MessageText = "";
            while (MessageText != "exit") 
            {
                GetNewMessage();
                MessageText = Console.ReadLine();
                if (MessageText.Length > 0) 
                {
                    Message Sendmsg = new Message(UserName, MessageText, DateTime.Now);
                    API.SendMessage(Sendmsg);
                }
            }
        }
    }
}
