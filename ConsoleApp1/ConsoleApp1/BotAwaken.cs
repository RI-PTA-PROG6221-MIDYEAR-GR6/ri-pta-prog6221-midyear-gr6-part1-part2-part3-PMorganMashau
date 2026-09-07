using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BotAwaken
    {
        bool running = true;
        string name;
        string bot = "CSCB";
        public BotAwaken()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{bot}");
            Console.ResetColor();
            Console.Write(": ");
            string requestName = "Hi , what is your name?";
            foreach (var c in requestName)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine("");
            Console.Write("> ");
            name = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("*****************************");
            Console.WriteLine($"*  User: {name}            *");
            Console.WriteLine($"*   Bot:  {bot}");
            Console.WriteLine("*****************************");
            Console.WriteLine("");
            string filePath = "art.txt";
            string art = File.ReadAllText(filePath);
            //Console.WriteLine(art);
            foreach (var t in art) {
                Console.Write(t);
                Thread.Sleep(20);
            }
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>----<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>----<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--<<O>>--\r\n");
            Console.ResetColor();


            Console.WriteLine($"{bot}: Nice to meet you {name}.I am CSCB, a Cyber Security awareness ChatBot. You can ask me anything about cyber security.");
            Console.WriteLine("   Or say exit to end the program.");
            Console.WriteLine("Say change bot name to change my name");
            //
            while (running)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{bot}");
                Console.ResetColor();
                Console.WriteLine(":");
                string instruction = "Ask me about Cyber Security, passwords, malware, phishing, safe browsing, cyber attacks, or say hints for extra features";
                foreach (var b in instruction)
                {
                    Console.Write(b);
                    Thread.Sleep(20);
                }
                Console.WriteLine("");
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
                else if (message.ToLower().Contains("restart") || message.ToLower().Contains("reset") || message.ToLower().Contains("reboot"))
                {
                    BotAwaken ba = new BotAwaken();
                    //Restarting the bot by creating a new instance of BotAwaken
                }
                else if (message.ToLower().Contains("hello") || message.ToLower().Contains("hey"))
                {
                    Console.WriteLine($"Hello {name}!");
                }
                else if (message.ToLower().Trim().Contains("change bot name") || message.ToLower().Trim().Contains("change your name"))
                {
                    changeBotName();
                }
                else if (message.ToLower().Trim().Contains("how are you") || message.ToLower().Trim().Contains("how are you doing") || message.ToLower().Trim().Contains("how you doing") || message.ToLower().Trim().Contains("hud"))
                {
                    Random r = new Random();
                    int randomNumber = r.Next(1, 4);
                    string[] howBotIs = { "I'm doing well, thank you for asking!", "I'm doing great, thanks for asking!", "I'm doing fine, thank you for asking!" };
                    Console.WriteLine(howBotIs[randomNumber - 1]);
                }
                else if (message.ToLower().Trim().Contains("safe browsing") || message.ToLower().Trim().Contains("safe surfing") || message.ToLower().Trim().Contains("safe web surfing"))
                {
                    safeBrowsing();
                }
                else if (message.ToLower().Trim().Contains("change name") || message.ToLower().Trim().Contains("change username") || message.ToLower().Trim().Contains("change user name"))
                {
                    changeName();
                }
                else if (message.ToLower().Trim().Contains("where are you") || message.ToLower().Trim().Contains("where you at"))
                {
                    Random e = new Random();
                    int randomNumber = e.Next(1, 8);
                    string[] locations = { "in the cloud", "in the PC's CPU", "in the RAM", "in the hard drive", "in the motherboard", "right here with you", "Planning on being in the internet sson" };
                    Console.WriteLine($"I'm {locations[randomNumber - 1]}!");
                }
                else if (message.ToLower().Trim().Contains("what is your purpose") || message.ToLower().Trim().Contains("what are you"))
                {
                    Console.WriteLine("My purpose is to educate you about cyber security!");
                }
                else if (message.ToLower().Trim().Contains("hint") || message.ToLower().Trim().Contains("hints"))
                {
                    //Show Extra features (hints)
                    showHints();
                }
                else if (message.ToLower().Contains("exit") || (message.ToLower().Contains("end") || (message.ToLower().Contains("stop"))))
                {
                    Console.WriteLine("Ending Program.");
                    Console.WriteLine("Ending Program in");
                    string countdown = "54321";
                    foreach (var count in countdown) {
                        Console.Write(count);
                        Thread.Sleep(60);
                    }
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
                Dictionary<string, string> responses = new Dictionary<string, string>
                {
                    { "passwords", "For strong security, use long, unique passwords for every account (ideally 16+ characters with a mix of letters, numbers, and symbols), avoid personal info or common words, and never reuse passwords across sites. The best way to manage this is with a reputable password manager that encrypts your vault, generates random passwords, and supports multi-factor authentication for your master account. Keep your master password very strong, enable 2FA on the manager and important accounts, and avoid storing passwords in plain text, your browser, or sending them via email or messages." },
                    { "malware", "Malware, short for malicious software, is any program or code intentionally designed to harm, disrupt, or gain unauthorized access to computers, networks, or data. It includes threats like viruses, worms, Trojans, ransomware, spyware, and adware, and is used by attackers to steal information, encrypt files for ransom, spy on users, or take control of devices." },
                    { "phishing", "Phishing is a cyberattack where scammers send fake emails, messages, or websites that look legitimate to trick you into giving up sensitive data or downloading malware. For example, you might get an email that appears to be from your bank saying your account will be locked unless you click a link and verify your details; the link leads to a fake login page that steals your username and password." },
                    { "cybersecurity", "Cyber security (or cybersecurity) refers to the practice of protecting computers, networks, software, data, and other digital systems from unauthorized access, attacks, damage, or theft by using a combination of tools, policies, processes, and technologies." },
                    { "safe browsing", "Safe browsing is how you protect yourself, your personal data, and your devices from online threats while you surf the internet. When you use safe browsing features, your browser acts as a shield, checking every link you click against databases of known dangers before you open them." }
                };
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
            Console.WriteLine("2. Change Bot Name");
            Console.WriteLine("3. Restart Bot");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    changeName();
                    break;
                case 2:
                    changeBotName();
                    break;
                case 3:
                    BotAwaken ba = new BotAwaken();
                    //Restarting the bot by creating a new instance of BotAwaken
                    break;
            }
        }
        internal void malware()
        {
            Console.WriteLine("");
            Console.WriteLine("MALWARE");
            SoundPlayer malware = new SoundPlayer("malware.wav");
            malware.Play();
            string malwareTxt = "Malware, short for malicious software, is any program or code intentionally designed to harm, disrupt, or gain unauthorized access to computers, networks, or data. It includes threats like viruses, worms, Trojans, ransomware, spyware, and adware, and is used by attackers to steal information, encrypt files for ransom, spy on users, or take control of devices.";
            foreach (var m in malwareTxt) {
                Console.Write(m);
                Thread.Sleep(20);
            }
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
        internal void changeBotName()
        {
            Console.WriteLine("");
            Console.WriteLine("---Change Bot Name---");
            Console.WriteLine($"{bot}: Enter my new name");
            Console.Write("New name: ");
            bot = Console.ReadLine();
            Console.WriteLine($"Done! I will now call myself {bot}!");
            Console.WriteLine("");
        }
    }
}
