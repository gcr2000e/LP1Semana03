using System;
using System.Reflection.Metadata.Ecma335;

namespace TrapAnalyzer
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            TrapType trap = Enum.Parse<TrapType>(args[0]);
            PlayerGear gear = ParseGear(args);
            bool survives = CanSurviveTrap(trap, gear);
            DisplayResult(trap, survives);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the player gear.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The player gear.</returns>
        private static PlayerGear ParseGear(string[] args)
        {
            return Enum.Parse<PlayerGear>(args[1]);
        }

        /// <summary>
        /// Can the player survive the trap given the gear it has?
        /// </summary>
        /// <param name="trap">The trap the player falls into.</param>
        /// <param name="gear">The gear the player has.</param>
        /// <returns>Wether the player survived the trap or not.</returns>
        private static bool CanSurviveTrap(TrapType trap, PlayerGear gear)
        {
            if (trap == TrapType.FallingRocks && gear == PlayerGear.Helmet ||
            trap == TrapType.SpinningBlades && gear == PlayerGear.Shield ||
            trap == TrapType.PoisonGas && gear == PlayerGear.Helmet
            && gear == PlayerGear.Shield ||
            trap == TrapType.LavaPit && gear == PlayerGear.Boots)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Display information on wether the player survived the trap or not.
        /// </summary>
        /// <param name="trap">The trap the player has fallen into.</param>
        private static void DisplayResult(TrapType trap,
        bool survives)
        {
            if (trap == TrapType.FallingRocks || trap == TrapType.SpinningBlades
            || trap == TrapType.PoisonGas || trap == TrapType.LavaPit
            && survives == true)
            {
                Console.WriteLine($"Player survives {trap}");
            }
            else
            {
                Console.WriteLine($"Player dies due to {trap}");
            }
            return;
        }
    }
}
