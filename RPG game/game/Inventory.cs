using System;

namespace game
{
    public class Inventory
    {
        protected int damage;
        private int armour;
        private int strenght;
        protected int domageInStruck { get; set; }
        
        

        public Inventory()
        {
            damage = 10;
            armour = 10;
            strenght = 100;
        }

        private Random damageGen = new Random();
        public void attackMonster(out int value)
        {
            Console.WriteLine("You struck.");
            domageInStruck = damageGen.Next(1, damage);
            Console.WriteLine($"Impact damage is {domageInStruck}");
            value = domageInStruck;
            
        }
        
        
    }
}