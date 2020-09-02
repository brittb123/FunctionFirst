using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        void GetDirection()
        {
            Console.WriteLine(" Type forward to go forawrd");
            Console.WriteLine(" Type back to go back");
            Console.WriteLine(" Type look to look around");
          
        }
        
        
        //entering and exiting rooms
        void enterRoom(int roomnumber)
        {
           
            switch(roomnumber)
            {
                case 0:
                    Console.WriteLine("You are in the beginning chamber");
                    break;
                
            }
            GetDirection();
            string directionChoice = Console.ReadLine();
            if (directionChoice == "forward")
            {
                enterRoom(roomnumber + 1);
            }
        }
        void PotionPouch()
        {
            Console.WriteLine("Small health potions: " + numberOfSmallHealth);
            Console.WriteLine("Medium health potions: " + numberOfMediumHealth);
            Console.WriteLine("Large health potions: " + numberOfLargeHealth);
            Console.WriteLine("Press 1 to use a small health potion");
            Console.WriteLine("Press 2 to use a for medium health potion");
            Console.WriteLine("Press 3 to use a large health potion");

            //Potion pouch selection
            char pouchchoice = Console.ReadKey().KeyChar;
            
            


                if (pouchchoice == '1' && numberOfSmallHealth > 0)
                {
                    Console.WriteLine("You take a drink and toss the bottle restoring 25 health");
                    _playerHealth += 20;
                    PotionMaxHealed();
                }
                else if (pouchchoice == '2' && numberOfMediumHealth > 0)
                {
                    Console.WriteLine("You take a decent sized glass and drink as fast as possible, " +
                        "you healed for 50 health");
                    _playerHealth += 50;
                    PotionMaxHealed();
                }
                else if (pouchchoice == '3' && numberOfLargeHealth > 0)
                {
                    Console.WriteLine("You grab a large jug and drink very fast, " +
                        "you restore 75 health");
                    _playerHealth += 75;
                    PotionMaxHealed();
                }
            
        }

      
        //potions and poisons
        float smallHealthPotion = 25;
        int numberOfSmallHealth = 0;
        int numberOfMediumHealth = 0;
        int numberOfLargeHealth = 0;

        // Potions and health max
        float _playerHealth = 100.0f;
        float _maxHealth = 100.0f;
        float PotionMaxHealed()
        {
            if (_playerHealth > _maxHealth)
            {
                _playerHealth = 100;
            }
            return _playerHealth;
        }

        //Run the game
        public void Run()
        {
            Start();
            Console.WriteLine("\nYou waken up by a loud thunder and see your in chains in a dark tower");
            Console.WriteLine("The walls are mossy and made of cobblestone as the floors look new and wooden");
            Console.WriteLine("A voice in your mind laughs and claims that a book and quill is on the table");
            Console.WriteLine("You walk to the table and see the book open and ask for your name");
            string name = Console.ReadLine();
            Console.WriteLine("So you are " + name + "Victom of tower of Descension?");
            Console.WriteLine("Press 1 for yes and 2 for No");
            char readyToBegin = Console.ReadKey().KeyChar;
            
            

                if (readyToBegin == '1')
                {
                    Console.WriteLine("HAHAHA So " + name + "We will see if you will ascend the Descension Towner!" +
                        "Begin the Challenege");
                }
                if (readyToBegin == '2')
                {
                    Console.WriteLine("You dont even know your name? This will be fun to watch you descend. Try again" +
                        "to remember your name");
                   
                }
                else
                {
                    Console.WriteLine(" You wont even make it out of the first room without a name.");
                }
            
        }

        //Performed once when the game begins
        public void Start()
        {
            Console.WriteLine("'Descension is always a step to Ascension'");
            Console.WriteLine("'You mock it but, Ha I will make sure You will learn that in person'");
            Console.ReadKey();
        }

        //Repeated until the game ends
        public void Update()
        {

          
        }

        
        //Performed once when the game ends
        public void End()
        {
         
        }
    }
}