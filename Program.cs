using System;
using System.Linq;
using World;
using Them = System.Collections.Generic.List<World.Human>;

namespace Vevo
{
    public class BandAid30
    {
        public static readonly Human Me = new Human()
        {
            KnowsItsChristmas = true
        };

        static void Main(string[] args)
        {
            var they = new Them();
            AskThem(they);
            if (!they.Contains(Me)) //in case they didn't ask me.
                they.Add(Me);

            int knows = they.Count(p => p.KnowsItsChristmas == true);
            int doesntknow = they.Count(p => p.KnowsItsChristmas == false);
            int wedontknowiftheyknow = they.Count(p => p.KnowsItsChristmas == null);
            int total = they.Count;

            if (knows == total)
            {
                Console.WriteLine("They know.");
                return;
            }

            if (doesntknow == total)
            {
                Console.WriteLine("They don't know.");
                return;
            }

            if (wedontknowiftheyknow > 0)
            {
                Console.WriteLine("We don't know.");
                return;
            }

            Console.WriteLine("Some know and some don't know.");
            return;

        }

        private static void AskThem(Them they)
        {
            throw new NotImplementedException();
        }
    }
}

namespace World
{
    public class Human
    {
        public bool? KnowsItsChristmas;
    }
}

