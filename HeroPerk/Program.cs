using System;
using HeroPerks;

namespace HeroPerk
{
    public class Program
    {
        [Flags]

        enum Perks
        {
            WarpShift = 1 << 0,
            Stealth = 1 << 1,
            AutoHeal = 1 << 2,
            DoubleJump = 1 << 3
        }
        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("!Unkown perk!");
                return;
            }

            string input = args[0].ToLower();
            Perks playerPerks = 0;
            int wCharCount = 0, aCharCount = 0, sCharCount = 0, dCharCount = 0;

            foreach (char c in input)
            {
                switch (c)
                {
                    case 'w':
                        wCharCount++;
                        break;

                    case 'a':
                        aCharCount++;
                        break;

                    case 's':
                        sCharCount++;
                        break;

                    case 'd':
                        dCharCount++;
                        break;

                    default:
                        Console.WriteLine("!Unknown perk!");
                        return;
                }
            }

            if (wCharCount % 2 == 1)
            {
                playerPerks |= Perks.WarpShift;
            }

            if (aCharCount % 2 == 1)
            {
                playerPerks |= Perks.AutoHeal;
            }

            if (sCharCount % 2 == 1)
            {
                playerPerks |= Perks.Stealth;
            }

            if (dCharCount % 2 == 1)
            {
                playerPerks |= Perks.DoubleJump;
            }

            if (playerPerks == 0)
            {
                Console.WriteLine("!No perks at all!");
                return;
            }

            if ((playerPerks & Perks.Stealth) != 0 &&
            (playerPerks & Perks.DoubleJump) != 0)
            {
                Console.WriteLine("!Silent jumper!");
            }

            if ((playerPerks & Perks.AutoHeal) == 0)
            {
                Console.WriteLine("!Not gonna make it!");
            }

            Console.WriteLine(playerPerks);

        }
    }
}
