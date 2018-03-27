using System;

namespace ConsoleAppPlayer
{
    class Player
    {
        private int level;
        private int experience;

        public int Experience {
            get
            {
                return experience;
            }
        }

        public string Name { get; }
        public int Level
        {
            get { return level; }
        }

        public Player(string name)
        {
            this.Name = name;
            level = 0;
            experience = 0;
        }

        public void AddExperience(int amount)
        {
            experience += amount;
            if (experience >= 100)
            {
                level += 1;
                experience = experience - 100;
            }
        }
    }

    class Program
    {
        static Random rndGen = new Random();

        static void Main(string[] args)
        {
            Player p = new Player("Joske");

            for (var i = 0; i < 20; i++)
            {
                var xp = 100;
                p.AddExperience(xp);
                Console.WriteLine($"Player just got {xp,2} experience and is now level {p.Level,2}.");
                Console.WriteLine($"Experience: {p.Experience}.");
            }
        }
    }
}
