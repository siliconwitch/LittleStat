﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_Stat
{
    class ProgramHelper
    {
        /*
         * Creates a character, with all base stats
         */
        public void CreateChar()
        {
            Console.Write("Enter PC name: ");
            string name = Console.ReadLine();

            if (character.CheckForOrCreateChar(name))
            {
                Console.WriteLine("Character exists so will be overwritten");
            }

            Console.Write("Enter STRENGTH value: ");
            character.SetCharStats(name, "Strength", StringConv());
            
            Console.Write("Enter VIGOUR value: ");
            character.SetCharStats(name, "Vigour", StringConv());
            
            Console.Write("Enter AGILITY value: ");
            character.SetCharStats(name, "Agility", StringConv());
            
            Console.Write("Enter INTELLECT value: ");
            character.SetCharStats(name, "Intellect", StringConv());
            
            Console.Write("Enter PERCEPTION value: ");
            character.SetCharStats(name, "Perception", StringConv());
            
            Console.Write("Enter TENACITY value: ");
            character.SetCharStats(name, "Tenacity", StringConv());
            
            Console.Write("Enter CHARISMA value: ");
            character.SetCharStats(name, "CHARISMA", StringConv());
            
            Console.Write("Enter INSTINCT value: ");
            character.SetCharStats(name, "INSTINCT", StringConv());
            
            Console.Write("Enter COMMUNICATION value: ");
            character.SetCharStats(name, "COMMUNICATION", StringConv());
        }


        /*
         * Displays characters stats.
         * Currently a placeholder
         */
        public void DisplayChar()
        {
            Console.WriteLine(character.ReturnStat("raj","Movement"));
            Console.ReadKey();
        }


        /*
         * Converts the text input into a float
         * shows an error message if not suceeded
         */
        private float StringConv()
        {
            while (true)
            {
                float res;

                if (float.TryParse(Console.ReadLine(), out res)) return res;

                else
                {
                    Console.WriteLine("Input has to be a number, try again: ");
                }
            }

        }


        /*
         * Local variables
         */
        Character character = new Character();
        float STRENGTH;
        float VIGOUR;
        float AGILITY;
        float INTELLECT;
        float PERCEPTION;
        float TENACITY;
        float CHARISMA;
        float INSTINCT;
        float COMMUNICATION;
    }
}
