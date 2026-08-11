using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BotAwaken
    {
        bool running = true;
        public BotAwaken()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("bot");
            Console.ResetColor();
            Console.WriteLine(": Hi , what is your name?");
            Console.Write("> ");
            string name = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("*****************************");
            Console.WriteLine($"*  User: {name}            *");
            Console.WriteLine("*****************************");
            Console.WriteLine("");
            string filePath = "art.txt";
            string art = File.ReadAllText(filePath);
            Console.WriteLine(art);
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>----<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>----<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--\r\n");
            Console.ResetColor();


            Console.WriteLine($": Nice to meet you {name}.I am CSCB, a Cyber Security awareness ChatBot. You cana ask me anything about cyber security.");
            Console.WriteLine("   Or say exit to end the program.");
            //
            //Whiel loop and if-statements here + methods
        }
    }
}