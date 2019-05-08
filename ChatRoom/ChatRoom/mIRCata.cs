using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    class mIRCata
    {
        private List<string> history;
        public string History 
        { 
            get
            {
                return string.Join("\r\n", this.history);
            }
        }

        public string User { get; private set; }

        public mIRCata(string User)
        {
            this.User = User;
            this.history = new List<string>();
        }

        public void JoinChatRoom(ChatRoom room)
        {
            room.MessageSend += this.OnMessageReceived;
        }

        public void SendMessage(ChatRoom room, string content)
        {
            room.PublishMessage(this.User, content);
        }



        protected void OnMessageReceived(object sender, ChatMessageEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            var msgToPrint = "<-- [" + this.User + "] | " + args.Author + " ==== " +  args.SentOn + " ==== " + args.Content;
            this.history.Add(msgToPrint);
            Console.WriteLine(msgToPrint);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
