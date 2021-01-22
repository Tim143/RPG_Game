using System;

namespace game
{
    public class Monster:Hero
    {
        private int monsterHP;
        private int monsterDamage;
        private int monsterLVL;

        private Random monsterGeneration = new Random();
        
        public Monster()
        {
            monsterHP = monsterGeneration.Next(100,heroHP+300);
            monsterDamage = monsterGeneration.Next(1,damage-1);
            monsterLVL = monsterGeneration.Next(0, heroLVL + 5);
        }

        public void printMonster()//using only when u see monster at first
        {
            Console.WriteLine($"Monster HP={monsterHP}");
            Console.WriteLine($"Monster damage={monsterDamage}");
            Console.WriteLine($"Monster lvl={monsterLVL}");
        }

        public void getDamage(ref int value)
        {
            domageInStruck = value;
            Console.WriteLine($"Monster get {domageInStruck} damage points.");
            monsterHP -= domageInStruck;
        }

        public void attackHero(out int monsterAttack)
        {
            Console.WriteLine("Monster has struck you.");
            monsterDamage = monsterGeneration.Next(1, monsterDamage);
            Console.WriteLine($"Impact damage is {monsterDamage}");
            monsterAttack = monsterDamage;
        }
    }
}