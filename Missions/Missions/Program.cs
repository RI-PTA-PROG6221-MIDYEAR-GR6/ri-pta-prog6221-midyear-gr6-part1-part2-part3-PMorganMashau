using System;

namespace Space1 {
    class Program { 
        static bool hasProfile = false;
        static string name;
        static List<string> missions = new List<string>();
        static bool hasMissions = false;
        static bool running = true;
        public static void Main(string[] args) {
            while (running) {
                if (hasProfile.Equals(true))
                {
                    continueProfile(name, missions, hasMissions);
                }
                else
                {
                    startProfile(name, missions);
                }
            }
        }
        static void startProfile(string name,List<string> missions) {
            Console.WriteLine("---Starting Profile---");
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}!");
            Console.WriteLine("");
            hasProfile = true;
            continueProfile(name,missions,hasMissions);
        }
        static void continueProfile(string name, List<string> missions,bool hasMissions) {
            Console.WriteLine($"---Welcome back {name}---");
            if (hasMissions)
            {
                Console.WriteLine("Your missions:");
                int count = 1;
                foreach (var mission in missions)
                {
                    Console.Write(count + $": {mission}");
                }
            }
            else { 
                Console.WriteLine("You have no missions.");
                Console.WriteLine("Add missions? (Y/N)");
                string ans = Console.ReadLine();
                if (ans.ToLower().Trim().Equals("y")) {
                    addMissions(missions);
                }
            }
        }

        static void addMissions(List<string> missions) {
            Console.Write("Number of Missions to add: ");
            int numOfMissions = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 0; i < numOfMissions; i++) {
                Console.WriteLine($"Enter mission: {count}");
                string mission = Console.ReadLine();
                missions.Add(mission);
                count++;
                Console.WriteLine("");
                Console.WriteLine("Mission added!");
            }
        }
    }
}