using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        //Run the game
        public void Run()
        {

        }

        //Performed once when the game begins
        public void Start()
        {

        }

        //Repeated until the game ends
        public void Update()
        {
            void Battlemenu()
            {
                Console.WriteLine("You open your backpack which pocket do you open?");
                Console.WriteLine("Press 1 to open potion and poison poutch");
                Console.WriteLine("Press 2 to open books and spell tomes!");
                Console.WriteLine("Press 3 to open small arms pocket!");
                Console.WriteLine("Press 4 to exit the backpack!");
                char backpackChoice = Console.ReadKey().KeyChar;
                if (backpackChoice == '1')
                {
                    Console.WriteLine("You open the pouch what do you wish to use?");
                }
            }
        }

        //Performed once when the game ends
        public void End()
        {

        }
    }
}