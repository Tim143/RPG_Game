using System;

namespace game
{
    public class Hero:Inventory
    {
        private string heroName;
        protected int heroHP;
        private int money;
        protected int heroLVL;
        private int score;

        public Hero()
        {
            heroName = "Gerald";
            heroLVL = 0;
            money = 500;
            heroHP = 1000;
        }

        public void preHistory()
        {
            Console.WriteLine($"You are a great warrior whose name everyone knows.{heroName} from Rivia." +
                              $"A warrior whose name strikes fear and terror in your enemies." +
                              $"Unfortunately, the army of wild trolls took your wife and daughter to their dungeons." +
                              $"Find them and return the honor and proud name of Merigold to your home."+
                              $"But it's not so simple, you have to go through a bunch of terrible tests " +
                              $"and dungeons in search of your family.Good luck on this dangerous and exciting journey.");
        }

        public void InformationAboutHero()
        {
            Console.WriteLine($"Your name is {heroName}.");
            Console.WriteLine($"Now, you have {heroLVL} level.");
            Console.WriteLine($"Now, your base HP is {heroHP}.But it will rise with you level.");
            Console.Write($"You have {money} coins to spent it."); 
            Console.WriteLine($"Buy new armour in the shop, that will be more powerfull than you have now.");
        }
        
        public void getDamageFromMonster(ref int monsterAttack)
        {
            Console.WriteLine($"My damage is {monsterAttack}");
            heroHP -= monsterAttack; 
        }
    }
}