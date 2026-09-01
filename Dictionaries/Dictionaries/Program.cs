
using System;
using System.Media;

namespace Dict {
    class Program
    {
        
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer();
            Dictionary<string,string> responses = new Dictionary<string, string>() {
                { "Hello","Hello to you too!"},
                { "How are you", "I am doing okay, what about you?"}
            };
            responses.Add("End","Ending Program");
            responses.Remove("Hello");
            foreach (var replies in responses)
            {
                Console.WriteLine(replies.Key +" "+ replies.Value);
            }
            //----------------------------------------Just a divider----------------------------------------
            string a = @"   _____      _                  _____                      _ _                                                                _____ _           _   ____        _   
  / ____|    | |                / ____|                    (_) |             /\                                               / ____| |         | | |  _ \      | |  
 | |    _   _| |__   ___ _ __  | (___   ___  ___ _   _ _ __ _| |_ _   _     /  \__      ____ _ _ __ ___ _ __   ___  ___ ___  | |    | |__   __ _| |_| |_) | ___ | |_ 
 | |   | | | | '_ \ / _ \ '__|  \___ \ / _ \/ __| | | | '__| | __| | | |   / /\ \ \ /\ / / _` | '__/ _ \ '_ \ / _ \/ __/ __| | |    | '_ \ / _` | __|  _ < / _ \| __|
 | |___| |_| | |_) |  __/ |     ____) |  __/ (__| |_| | |  | | |_| |_| |  / ____ \ V  V / (_| | | |  __/ | | |  __/\__ \__ \ | |____| | | | (_| | |_| |_) | (_) | |_ 
  \_____\__, |_.__/ \___|_|    |_____/ \___|\___|\__,_|_|  |_|\__|\__, | /_/    \_\_/\_/ \__,_|_|  \___|_| |_|\___||___/___/  \_____|_| |_|\__,_|\__|____/ \___/ \__|
         __/ |                                                     __/ |                                                                                             
        |___/                                                     |___/                                                                                              ";
            player.Play();
            Console.WriteLine(a);
            Dictionary<string,List<string>> chats = new Dictionary<string, List<string>>(){ 
                { "hello" ,new List<string>{ "hi","hey","hello"} },
                { "Favourite module", new List<string>{ "PROG","SAND","IPMA","DATA"} }
            };

            chats.Clear();// Clear the dictionary, you can comment this so the output works bafo
            if (chats.ContainsKey("hello"))
            {
                Console.WriteLine("Key exists");
            }
            else {
                Console.WriteLine("Key does not exist");
            }
        }
    }
}