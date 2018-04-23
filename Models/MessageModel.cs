using System;

namespace lightning_dotnet_okta.Models
{
    public class Message
    {
        public string Id { get; set; }

        public DateTime Date { get; set;}
        public string Text { get; set; }

        public Message(DateTime date, string text) {
            Date = date;
            Text = text;
        }
    }
}