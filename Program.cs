using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            mail_core temp = new mail_core();
            Console.WriteLine("Press enter to send email to : Receiver Name [receiver.email@gmail.com]");
            Console.ReadLine();
            temp.NewMail("receiver.email@gmail.com", "Receiver Name", "sender.email@gmail.com", "Sender Name", "Subject Line Here", "Email content goes here", "String file attachment here");
            temp.smtpServerSettings("smtp.gmail.com", 587, "sender.email@gmail.com", "SenderPasswordHere", true);
            Console.WriteLine("sending...");
            Console.WriteLine("=============================================================");
            temp.sendMail();
            Console.WriteLine("=============================================================");
            Console.ReadLine();
        }
    }
}
