using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;

namespace HelloWorld
{


    public struct items
    {
        public string name;
        public int statBoost;
    }
    class Game
    {

        
        bool _gameOver = false;
       public Player player1 = new Player("Gim", 100, 15, 3);
       public Player player2 = new Player("Curi", 150, 20, 3);
        
        items longsword;
        items dagger;
        items bow;
        items shortsword;
        items fireballScrolls;
        
       
        //initializes items
        public void InitalItems()
        {
            
            longsword.statBoost = 25;
            longsword.name = "longsword";
            dagger.statBoost = 10;
            dagger.name = "dagger";
            bow.statBoost = 10;
            bow.name = "bow";
            shortsword.statBoost = 15;
            shortsword.name = "shortsword";
            fireballScrolls.statBoost = 20;
            fireballScrolls.name = "Fireball Scrolls";
            
        }


        //Run the game
        public void Run()
        {
            Start();

            while (_gameOver = false)
            {
                Update();

                
            }
            End();
        }

        public void GetInput(out char input, string option1, string option2)
        {
           
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            input = ' ';
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;


                if (input != '1' && input != '2')
                {
                    Console.WriteLine("Thats not a weapon");
                }
                input = ' ';
                Console.WriteLine("Alright good choice now you player 2");
                GetInput(out input, "longsword", "dagger", "Which weapon do you want?");
            }
        }
        //Gets player input for various things
        public void GetInput(out char input, string option1, string option2,  string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            input = ' ';
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;


                if (input != '1' && input != '2')
                {
                    Console.WriteLine("Thats not a weapon");
                }
                input = ' ';
                Console.WriteLine("Alright good choice now you player 2");
                GetInput(out input, "longsword", "dagger", "Which weapon do you want?");
            }
        }

        //Gets player input for various things also
        public void Input(out char input, string option1, string option2, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            input = ' ';
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;


                if (input != '1' && input != '2')
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
        public void Input(out char input, string option1, string option2, string option3, string option4, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            Console.WriteLine("3. " + option3);
            Console.WriteLine("4. " + option4);
            input = ' ';
            while (input != '1' && input != '2' && input != '3' && input != 4)
            {
                input = Console.ReadKey().KeyChar;


                if (input != '1' && input != '2' && input != '3' && input != '4')
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }

        
        // Players starting weapons and boosts
        public void SelectItem()
        {

            Console.WriteLine("Welcome Players, Player One please choose a weapon");
            Console.WriteLine("Press 1 for longsword");
            Console.WriteLine("Press 2 for dagger");
            Console.WriteLine("Press 3 for bow");
            Console.WriteLine("Press 4 for shortsword");
            char input = Console.ReadKey().KeyChar;
            while (input != '1' && input != '2')
            {

                if (input == '1')
                {
                    player1.AddItem(longsword, 1);
                    player1.PrintStats();
                    

                }

                else if (input == '2')
                {
                    player1.AddItem(dagger, 1);
                    player1.PrintStats();
                    
                }
                else if (input == '3')
                {
                    player1.AddItem(bow, 1);
                }
                else if (input == '4')
                {
                    player1.AddItem(shortsword, 1);
                }

                Console.WriteLine("Now you may choose a weapon player 2");


            }
        }

        public void SwitchWeapons(Player Player)
        {
            items[] inventory = player1.GetInv();
            char input;
            for(int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].name + "Damage: " + inventory[i].statBoost);
            }




        }

        //When Players enter battle
        public void Battle()
        {
            Console.WriteLine("Now go!");

            while (player1.GetStillAlive() && player2.GetStillAlive())
            {
                player1.PrintStats();
                player2.PrintStats();

                char input = ' ';
                GetInput(out input, "Attack", "Change weapon", "What do you do player?");
                if (input == '1')
                {
                    player1.Attack(player2);

                }
                else
                {
                    Console.WriteLine("No, you need to hrow a spine and fight!");
                }
                input = ' ';
                GetInput(out input, "Attack", "No", "Your turn to attack player 2");
                if (input == '1')
                {
                    player2.Attack(player1);
                }
                
            }
        }


        

        //Performed once when the game begins
        public void Start()
        {
           
            InitalItems();
            SelectItem();
            SwitchWeapons(player1);
        }

        //Repeated until the game ends
        public void Update()
        {
            Battle();
            
        }


        //Performed once when the game ends
        public void End()
        {

        }
    }
}
