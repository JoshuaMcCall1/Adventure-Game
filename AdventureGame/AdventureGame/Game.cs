using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Game
    {
        // member variables (HAS A)
        Indian player;
        Forest forest;

        // constructor
        public Game()
        {
            player = new Indian();
            forest = new Forest();
        }

        // member methods (CAN DO)
        public void RunGame() // master function(method)
        {

            // Display the rules of the game
            DisplayInstructions();
            // do the first encounter
            int logsAdded = forest.DoBattleEncounter();
            player.numberOfLogs = player.numberOfLogs + logsAdded;
            // do the second encounter:
            int logsAdded2 = forest.DoBattleEncounter2();
            // do the third encounter, end of game, add logsearned:

        }
        
        public int DoBattleEncounter2()
        {
            Console.WriteLine("You encounter a bear! DECISION!");
            Console.WriteLine("Press [1] to FIGHT! Press [2] to RUN!");
            string userInput = Console.ReadLine();
            int logsEarned = 0;

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("You earn 5 logs for your bravery!");
                    logsEarned = 5;
                    break;
                case "2":
                    Console.WriteLine("You run away, trip, and drop 1 log!");
                    logsEarned = logsEarned -1;
                    break;
                default:
                    Console.WriteLine("Whoops, incorrect input.");
                    break;
            }
            return logsEarned;
            //if (userInput == "1")
            //{
            //    Console.WriteLine("You earn 5 logs for your bravery!");
            //    logsEarned = 5;
            //}
            //else
            //{
            //    Console.WriteLine("You run away, trip, and drop 1 logs!");
            //    logsEarned = 2;


        }
        public void DisplayInstructions()
        {
            Console.WriteLine("These are the instructions.");
        }
    }
}
