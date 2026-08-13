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
            Console.Write("Bot");
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
            while (running)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Bot");
                Console.ResetColor();
                Console.WriteLine(":Ask me about Cyber Security, passwords, malware, phishing, safe browsing, cyber attacks");
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{name}>");
                Console.ResetColor();
                string message = Console.ReadLine();
                if (message == null)
                {
                    Console.WriteLine("Didn't quite catch that,could you rephrase please!");
                }
                else if (message.ToLower().Contains("passwords") || (message.ToLower().Contains("password")))
                {

                    //passwords();
                }
                else if (message.ToLower().Contains("malware"))
                {
                    //malware();

                }
                else if (message.ToLower().Contains("exit") || (message.ToLower().Contains("end") || (message.ToLower().Contains("stop"))))
                {
                    Console.WriteLine("Ending Program.");
                    Environment.Exit(0);
                }
                else if (message.ToLower().Contains("phishing"))
                {
                    //phishing();

                }
                else if (message.ToLower().Trim().Contains("cyberattacks") || (message.ToLower().Trim().Contains("cyber attack") || (message.ToLower().Trim().Contains("attack"))))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--");
                    Console.ResetColor();
                    //cyberAttack();

                }
                else if (message.ToLower().Contains("cybersecurity") || (message.ToLower().Trim().Contains("cyber security") || (message.ToLower().Trim().Contains("security"))))
                {
                    //cyberSecurity();
                }
                else
                {
                    Console.WriteLine("Didn't quite catch that,could you rephrase please!");
                }
            }
        }
    }
}