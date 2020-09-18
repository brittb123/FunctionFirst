using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HelloWorld
{
    public class Player
    {


        private string _name;
        private int _health;
        private int _damage;
        public int level;
        public int strength;
        public int dexterity;
        public int healthstat;
        public int focus;
        public int aim;
        public int EXP;
        private items[] inventory;
        

        public Player()
        {
            level = 1;
            EXP = 0;
            _health = 100;
            _damage = 10;
            strength = 10;
            dexterity = 10;
            healthstat = 10;
            focus = 10;
            aim = 10;
        }

        public Player(string nameVal, int healthVal, int damageVal, int inventorySize)
        {
            _name = nameVal;
            _health = healthVal;
            _damage = damageVal;
            inventory = new items[inventorySize];
        }

        public void AddItem(items items, int index)
        {
            inventory[index] = items;
        }

        public void EquipItem(int itemIndex)
        {
            _damage = inventory[itemIndex].statBoost;
        }

        public string GetName()
        {
            return _name;
        }

        public bool GetStillAlive()
        {
            return _health > 0;
        }

        public void Attack(Player enemy)
        {
            enemy.TakeDamage(_damage);
        }


        public void PrintStats()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Damage: " + _damage);
        }

        private void TakeDamage(int damageVal)
        {
            if (GetStillAlive())
            {
                _health -= damageVal;
            }
            Console.WriteLine(_name + " took " + damageVal + " damage!!");
        }

        public void LevelUp()
        {
            Console.WriteLine("Well look at you leveling up!");
            Console.WriteLine("Please choose one to improve!");
            Console.WriteLine("1. Strength: " + strength);
            Console.WriteLine("2. Dexterity: " + dexterity);
            Console.WriteLine("3. Health: " + healthstat);
            Console.WriteLine("4. Focus: " + focus);

            int choice = Console.ReadKey().KeyChar;
            switch (choice)
            {
                case 1:
                    strength += 2;
                    break;

                case 2:
                    dexterity += 2;
                    break;

                case 3:
                    _health += 2;
                    break;

                case 4:
                    focus += 5;
                    break;

                case 5:
                    aim += 5;
                    break;
            }


           
        }
    }
}
