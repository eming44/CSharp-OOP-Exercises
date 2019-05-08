using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{

    //much buggy
    public class SkypeClient
    {
        public string User { get; private set; }

        public SkypeClient(string User)
        {
            this.User = User;
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
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("{0} just received the message: {1} - {2}: {3}", this.User, args.Author, args.SentOn, args.Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
