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
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("Bot Status:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Offline");
            Console.ResetColor();
            Console.WriteLine("Welcome to the Cyber Security Awareness Chatbot. Here to help you stay safe online.");
            Console.WriteLine("Say hi or hello to wake the bot, or say exit to end the program!");
            idle();
            
        }
        static void wakeBot()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.Write("Bot Status:");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Online!");
            Console.ResetColor();
            BotAwaken ba = new BotAwaken();
            
        }
        static void idle() {
            Console.Write("> ");
            string choice = Console.ReadLine();
            if (choice.ToLower().Contains("hi") || choice.ToLower().Contains("hello") || choice.ToLower().Contains("hey"))
            {
                wakeBot();
            }
            else if (choice.ToLower().Contains("exit"))
            {
                Console.WriteLine("Exiting Program");
                Environment.Exit(0);
            }
            else if (String.IsNullOrEmpty(choice))
            {
                idle();
            } else if (choice != "exit" || choice != "stop" || choice != "hi" || choice!= "hello") {
                Console.WriteLine("Please enter valid inputs.");
                idle();
            }
        }
    }
}
