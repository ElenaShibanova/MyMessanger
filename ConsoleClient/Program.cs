using System;
using Newtonsoft.Json;

namespace MyMessanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
            //{ "UserName":"RusAl","MessageText":"Privet","TimeStamp":"2022-07-13T11:34:20.1686757Z"}
            //RusAl < 13.07.2022 11:34:20 >:Privet
        
        }
    }
}
