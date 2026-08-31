using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BotAwaken
    {
        bool running = true;
        string name;
        public BotAwaken()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Bot");
            Console.ResetColor();
            Console.WriteLine(": Hi , what is your name?");
            Console.Write("> ");
            name = Console.ReadLine();

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


            Console.WriteLine($": Nice to meet you {name}.I am CSCB, a Cyber Security awareness ChatBot. You can ask me anything about cyber security.");
            Console.WriteLine("   Or say exit to end the program.");
            //
            while (running)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Bot");
                Console.ResetColor();
                Console.WriteLine(":Ask me about Cyber Security, passwords, malware, phishing, safe browsing, cyber attacks, or say hints for extra features");
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

                    passwords();
                }
                else if (message.ToLower().Contains("malware"))
                {
                    malware();

                }
                else if (message.ToLower().Trim().Contains("hint"))
                {
                    //Show Extra features (hints)
                    showHints();
                }
                else if (message.ToLower().Contains("exit") || (message.ToLower().Contains("end") || (message.ToLower().Contains("stop"))))
                {
                    Console.WriteLine("Ending Program.");
                    Environment.Exit(0);
                }
                else if (message.ToLower().Contains("phishing"))
                {
                    phishing();

                }
                else if (message.ToLower().Trim().Contains("cyberattacks") || (message.ToLower().Trim().Contains("cyber attack") || (message.ToLower().Trim().Contains("attack"))))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--");
                    Console.ResetColor();
                    cyberAttack();

                }
                else if (message.ToLower().Contains("attack") || message.Trim().ToLower().Contains("cyberattack"))
                {
                    Console.WriteLine("Cyber attack Method!!!");
                }
                else if (message.ToLower().Contains("cybersecurity") || (message.ToLower().Trim().Contains("cyber security") || (message.ToLower().Trim().Contains("security"))))
                {
                    cyberSecurity();
                }
                else
                {
                    Console.WriteLine("Didn't quite catch that,could you rephrase please!");
                }
            }
        }
        //METHODS
        internal void passwords()
        {
            Console.WriteLine("");
            Console.WriteLine("PASSWORDS");
            Console.WriteLine("For strong security, use long, unique passwords for every account (ideally 16+ characters with a mix of letters, numbers, and symbols), avoid personal info or common words, and never reuse passwords across sites. The best way to manage this is with a reputable password manager that encrypts your vault, generates random passwords, and supports multi-factor authentication for your master account. Keep your master password very strong, enable 2FA on the manager and important accounts, and avoid storing passwords in plain text, your browser, or sending them via email or messages.");
        }
        internal void showHints()
        {
            Console.WriteLine("");
            Console.WriteLine("----Features----");
            Console.WriteLine("1. Change username");
            Console.WriteLine("2. Back to topics");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    changeName();
                    break;
                case 2:
                    break;
            }
        }
        internal void malware()
        {
            Console.WriteLine("");
            Console.WriteLine("MALWARE");
            Console.WriteLine("Malware, short for malicious software, is any program or code intentionally designed to harm, disrupt, or gain unauthorized access to computers, networks, or data. It includes threats like viruses, worms, Trojans, ransomware, spyware, and adware, and is used by attackers to steal information, encrypt files for ransom, spy on users, or take control of devices.");
        }
        internal void phishing()
        {
            Console.WriteLine("");
            Console.WriteLine("PHISHING");
            Console.WriteLine("Phishing is a cyberattack where scammers send fake emails, messages, or websites that look legitimate to trick you into giving up sensitive data or downloading malware. For example, you might get an email that appears to be from your bank saying your account will be locked unless you click a link and verify your details; the link leads to a fake login page that steals your username and password.");
        }
        internal void cyberAttack()
        {
            Console.WriteLine("");
            Console.WriteLine("Cyber Attacks");
            Console.WriteLine("A cyber attack is a deliberate attempt to gain unauthorized access to computer systems, networks, or digital devices in order to steal, alter, disable, or destroy data and services. Attackers use methods such as phishing, malware, ransomware, denial-of-service attacks, and code injection to exploit weaknesses and compromise the confidentiality, integrity, or availability of information.");
        }
        internal void cyberSecurity()
        {
            Console.WriteLine("");
            Console.WriteLine("Cyber Security");
            Console.WriteLine("Cyber security (or cybersecurity) refers to the practice of protecting computers, networks, software, data, and other digital systems from unauthorized access, attacks, damage, or theft by using a combination of tools, policies, processes, and technologies.");
        }
        internal void safeBrowsing()
        {
            Console.WriteLine("");
            Console.WriteLine("Safe Browsing");
            Console.WriteLine("Safe browsing is how you protect yourself, your personal data, and your devices from online threats while you surf the internet. When you use safe browsing features, your browser acts as a shield, checking every link you click against databases of known dangers before you open them.");
        }

        internal void changeName()
        {
            Console.WriteLine("");
            Console.WriteLine("---Change Username---");
            Console.WriteLine("Bot: Enter your new name");
            Console.Write("New name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Done! I will now call you {name}!");
            Console.WriteLine("");
        }

    }
}