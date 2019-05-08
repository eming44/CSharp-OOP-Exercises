using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatRoom = new ChatRoom("TelerikAcademyChat");

            var gosho = new SkypeClient("gosho");
            var pesho = new mIRCata("pesho");
            var stamatka = new mIRCata("stamatka");
 
            gosho.JoinChatRoom(chatRoom);
            pesho.JoinChatRoom(chatRoom);
            stamatka.JoinChatRoom(chatRoom);

            pesho.SendMessage(chatRoom, "zdr kp haide na kopon");
            stamatka.SendMessage(chatRoom, "Pesho sori zaeta sym imam da ucha za izpit");
            gosho.SendMessage(chatRoom, "Haide v 33");


            Console.WriteLine(pesho.History);


        }
    }
}
