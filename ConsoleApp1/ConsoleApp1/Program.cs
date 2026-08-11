using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>----<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>----<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--\r\n");
            Console.ResetColor();
            string label = @" ██████ ███████  ██████ ██████                 ██████ ██    ██ ██████  ███████ ██████      ███████ ███████  ██████ ██    ██ ██████  ██ ████████ ██    ██      █████  ██     ██  █████  ██████  ███████ ███    ██ ███████ ███████ ███████ 
██      ██      ██      ██   ██               ██       ██  ██  ██   ██ ██      ██   ██     ██      ██      ██      ██    ██ ██   ██ ██    ██     ██  ██      ██   ██ ██     ██ ██   ██ ██   ██ ██      ████   ██ ██      ██      ██      
██      ███████ ██      ██████      █████     ██        ████   ██████  █████   ██████      ███████ █████   ██      ██    ██ ██████  ██    ██      ████       ███████ ██  █  ██ ███████ ██████  █████   ██ ██  ██ █████   ███████ ███████ 
██           ██ ██      ██   ██               ██         ██    ██   ██ ██      ██   ██          ██ ██      ██      ██    ██ ██   ██ ██    ██       ██        ██   ██ ██ ███ ██ ██   ██ ██   ██ ██      ██  ██ ██ ██           ██      ██ 
 ██████ ███████  ██████ ██████                 ██████    ██    ██████  ███████ ██   ██     ███████ ███████  ██████  ██████  ██   ██ ██    ██       ██        ██   ██  ███ ███  ██   ██ ██   ██ ███████ ██   ████ ███████ ███████ ███████ 
                                                                                                                                                                                                                                         
                                                                                                                                                                                                                                         ";

            Console.WriteLine(label);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Cyber Security Awareness Chatbot. Here to help you stay safe online.");
            Console.WriteLine("Say hi or hello to wake the bot");
            Console.Write("> ");
            string choice = Console.ReadLine();
            if (choice.ToLower().Contains("hi") || choice.ToLower().Contains("hello")) {
                wakeBot();
            }
        }
        static void wakeBot()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bot is Awake!");
            Console.ResetColor();
            BotAwaken ba = new BotAwaken();
            
        }
    }
}
