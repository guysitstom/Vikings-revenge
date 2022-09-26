using System;
using System.Collections;
using System.Net.Cache;
using System.Security.Cryptography;


public class MyProgram
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {
        //Rude awakening
        Console.WriteLine("You awake to the sounds of screamimg and " +
            "smell of smoke to find a viking across the room from you. Do you want " +
            "to [[quietly attack them]] or [[charge at them to knock them off their feet]]?");
        //Charge at them to knmock them off their feet
        Console.WriteLine("As you run at them they turn towards you with their axe raised and " +
            "they hit your arm causing a deep wound but you manage to knock them over and take " +
            "their axe and plunge it deep into their chest to kill them. Then you run outside.");
        //quietly attack them
        Console.WriteLine("As you walk up behind them you grab your axe off the floor and " +
            "behead the viking intruder in one strike and then quickly you run outside.");
        //you run outside
        Console.WriteLine("As you make it outside with your axe in hand you see a viking jarl " +
            "know to many as Bjørn the brutal as he beheads your father infrount if you as you " +
            "watch on helplessly while unable to do anything to help him. To your left you see " +
            "two brothers, Gorm and Birger, being pinned down and you feel capable of helping " +
            "one of them do you want to save Gorm or Birger?");
        int cpuhitpos;
        int hitpos;
        int cpudef;
        string playerhitpos;
        playerhitpos = "hi";
        hitpos = 0;
        int playerdmg;

        playerdmg = 5;
        double cpuhp;

        cpuhp = 20;
        double playeracdmg;
        double playerhp;

        playerhp = 20;
        int cpudmg;

        cpudmg = 4;
        double cpuacdmg;
        playeracdmg = 5;
        cpuacdmg = 4;
        while (cpuhp > 0)
        {
            hitpos = 0;
            while (hitpos == 0)
            {
                Console.WriteLine("Where would you like to hit? head, torso, or legs.");
                playerhitpos = Console.ReadLine();
                if (playerhitpos == "head")
                {
                    hitpos = 1;
                }
                else
                {
                    if (playerhitpos == "torso")
                    {
                        hitpos = 2;
                    }
                    else
                    {
                        if (playerhitpos == "legs")
                        {
                            hitpos = 3;
                        }
                    }
                }
            }
            cpudef = random.Next(3) + 1;
            if (hitpos == cpudef)
            {
                Console.WriteLine("They blocked your atempt to hit their " + playerhitpos);
                if (playerhitpos == "head")
                {
                    playeracdmg = cpudmg * 2;
                }
                else
                {
                    if (playerhitpos == "torso")
                    {
                        playeracdmg = cpudmg * 1.5;
                    }
                    else
                    {
                        if (playerhitpos == "legs")
                        {
                            playeracdmg = cpudmg * 1.2;
                        }
                    }
                }
                playerhp = playerhp - playeracdmg;
                if (playerhp < 0)
                {
                    playerhp = 0;
                }
                Console.WriteLine("Player hp is " + playerhp);
                if (playerhp == 0)
                {
                    Console.WriteLine("You have been defeated.");
                }
            }
            else
            {
                Console.WriteLine("you hit their " + playerhitpos);
                if (playerhitpos == "head")
                {
                    playeracdmg = playerdmg * 1.5;
                }
                else
                {
                    if (playerhitpos == "torso")
                    {
                        playeracdmg = playerdmg * 1.3;
                    }
                    else
                    {
                        if (playerhitpos == "legs")
                        {
                            playeracdmg = playerdmg;
                        }
                    }
                }
                cpuhp = cpuhp - playeracdmg;
                if (cpuhp < 0)
                {
                    cpuhp = 0;
                }
                Console.WriteLine("Enemy hp is " + cpuhp);
                if (cpuhp == 0)
                {
                    Console.WriteLine("You defeated the enemy.");
                }
            }
            hitpos = 0;
            while (hitpos == 0)
            {
                Console.WriteLine("Where would you like to defend? head, torso, or legs.");
                playerhitpos = Console.ReadLine();
                if (playerhitpos == "head")
                {
                    hitpos = 1;
                }
                else
                {
                    if (playerhitpos == "torso")
                    {
                        hitpos = 2;
                    }
                    else
                    {
                        if (playerhitpos == "legs")
                        {
                            hitpos = 3;
                        }
                    }
                }
            }
            cpuhitpos = random.Next(3) + 1;
            if (hitpos == cpudef)
            {
                Console.WriteLine("You blocked their atempt to hit your " + playerhitpos);
                if (playerhitpos == "head")
                {
                    playeracdmg = playerdmg * 2;
                }
                else
                {
                    if (playerhitpos == "torso")
                    {
                        playeracdmg = playerdmg * 1.5;
                    }
                    else
                    {
                        if (playerhitpos == "legs")
                        {
                            playeracdmg = playerdmg * 1.2;
                        }
                    }
                }
                cpuhp = cpuhp - playeracdmg;
                if (cpuhp < 0)
                {
                    cpuhp = 0;
                }
                Console.WriteLine("Enemy hp is " + cpuhp);
            }
            else
            {
                if (cpuhitpos == 1)
                {
                    cpuacdmg = cpudmg * 1.5;
                    Console.WriteLine("They hit your head");
                }
                else
                {
                    if (cpuhitpos == 2)
                    {
                        cpuacdmg = cpudmg * 1.3;
                        Console.WriteLine("They hit your torso");
                    }
                    else
                    {
                        if (cpuhitpos == 3)
                        {
                            cpuacdmg = cpudmg;
                            Console.WriteLine("They hit your legs");
                        }
                    }
                }
                playerhp = playerhp - cpuacdmg;
                if (playerhp < 0)
                {
                    playerhp = 0;
                }
                Console.WriteLine("Player hp is " + playerhp);
                if (playerhp == 0)
                {
                    Console.WriteLine("You have been defeated.");
                }
            }
        }
        Console.WriteLine("You defeated the enemy.");
    }

    // .NET can only read single characters or entire lines from the console.
    // The following function safely reads a double value.
    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
