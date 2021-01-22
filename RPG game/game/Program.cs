using System;

namespace game
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Console.BackgroundColor = "Black";
           
            Console.BackgroundColor = ConsoleColor.Black; // устанавливаем белый цвет фона для текста
            Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем красный цвет шрифта
            
            Console.WriteLine("\t\t\t Welcome to the desctope adventure game <Witcher, wild hunt> \t\t\t\t\t   ");
            Console.WriteLine("\t\t\t\t Do you want to start or undergo training? \t\t\t\t\t\t   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t 1)New game.\t\t\t\t\t\t\t\t\t\t   ");
            Console.WriteLine("\t\t\t\t 2)Training.\t\t\t\t\t\t\t\t\t\t   ");
            Console.WriteLine("\t\t\t\t 3)Close app.\t\t\t\t\t\t\t\t\t\t   ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===========================================================================================================================");

            bool repeadMenuChoice = true;
            while (repeadMenuChoice)
            {
                string menuChoice = Console.ReadLine();
                if (menuChoice == "1")
                {
                  Console.WriteLine("Let the game start.");
                  repeadMenuChoice = false;
                }
                else if (menuChoice == "2")
                {
                    Console.WriteLine("Let start the training.");
                    Console.Clear();
                    Console.Write("In this game, you have to go on a dangerous journey through the dungeons," +
                                      " which contain a bunch of smelly and terrible trolls.At each level of the" +
                                      " location, you will come across different enemies with different health,damage," +
                                      " and level characteristics.Be careful and watchful.");
                    
                    Console.WriteLine("cautious.In the story, the trolls stole your wife and child and dragged them to " +
                                      "their dungeon.You need to find them.The task is not easy , all you know about " +
                                      "these trolls is that their leader is the Emperor Emgyr Var-Emreis -- high elf " +
                                      "Aen-Elle.And he has his own plans for your family and maybe for you.Distrusful " +
                                      "of Gerald of rivia, the killer of monsters, for the battle will be great.\n");
                    Console.Write("Press any botton to continue....");
                    Console.ReadKey();
                    Console.WriteLine("In total, there will be 10 locations with dungeons, where you will have to " +
                                      "fight with trolls and the final arena is a battle with the Emperor Emgyr." +
                                      "Remember, if you die, your family will be killed.I suggest you consider the " +
                                      "basic level, where we will teach you the basic mechanics of the game. " +
                                      "Are you ready?\n");
                    
                    bool startTrainingIsSoHard = true;
                    while (startTrainingIsSoHard)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tPress <S> to start.");
                        Console.WriteLine("\tPress <Q> to exit.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string answerForStartTheTraining = Console.ReadLine();
                        if (answerForStartTheTraining == "Q" || answerForStartTheTraining == "q")
                        {
                            startTrainingIsSoHard = false;
                            return;
                        }
                        else if (answerForStartTheTraining == "S" || answerForStartTheTraining == "s")
                        {
                            startTrainingIsSoHard = false;
                            Console.WriteLine("start");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("Incorrect variant.Try again.");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                    }

                    repeadMenuChoice = false;
                }
                else if (menuChoice == "3")
                { 
                    return;
                }
                else
                {
                  Console.WriteLine("Please, select only existing points.");
                }
            }
            
        }
    }
}