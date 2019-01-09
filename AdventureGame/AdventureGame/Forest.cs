using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Forest
    {
        // member variables
        int numberOfLogs;
        int numberOfIndians;
        int toolsOrSuppliesNeeded;


        // constructor

        // member methods
        public int DoBattleEncounter()
        {
            Console.WriteLine("You encounter a cavalry man! DECISION!");
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
                    Console.WriteLine("You run away, trip, and drop 3 logs!");
                    logsEarned = -3;
                    break;
                default:
                    Console.WriteLine("Whoops, incorrect input.");
                    break;
            }
            return logsEarned;
        }
        // member variables
        //    int numberOfLogs;
        //int numberOfIndians;
        //int toolsOrSuppliesNeeded;


        // constructor

        // member methods

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
                    logsEarned -= 1;
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
