using System;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Net.Cache;
using System.Security.Cryptography;


public class MyProgram
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {

        {
            int choice;
            bool gormsaved;
            bool respect;
            bool raided;

            Typewrite("You awake to the sounds of screamimg and smell of smoke to find a viking across the room from you. Do you want to quietly attack them(1) or charge at them to knock them off their feet(2)?");
            Console.WriteLine("");
            choice = (int)Value();
            if (choice == 1)
            {
                Typewrite("As you walk up behind them you grab your axe off the floor and behead the viking intruder in one strike and then quickly you run outside.");
                Console.WriteLine("");
            }
            else
            {
                Typewrite("As you run at them they turn towards you with their axe raised and they hit your arm causing a deep wound but you manage to knock them over and take their axe and plunge it deep into their chest to kill them. Then you run outside.");
                Console.WriteLine("");
            }
            Typewrite("As you make it outside with your axe in hand you see a viking jarl know to many as Bjørn the brutal and he beheads your father infrount of you as you watch on helplessly while unable to do anything to help him. To your left you see two brothers, Gorm and Birger, being pinned down and you feel capable of helping one of them do you want to save Gorm(1) or Birger(2)?");
            Console.WriteLine("");
            choice = (int)Value();
            if (choice == 1)
            {

                // Change colour to blue
                Console.ForegroundColor = ConsoleColor.Blue;
                Typewrite("your story has been changed.");
                Console.WriteLine("");
                // Change colour to white
                Console.ForegroundColor = ConsoleColor.White;
                Typewrite("You run over to Gorm and fight the man pinning him to the floor.") ;
                Console.WriteLine("");
                battle(5 , 20);
                Typewrite("After killing him you help Gorm to his feet and go to try and save his brother. However Gorm doesn't rush to help his brother and so his brother Birger is killed before you're able to get over to him.You saved Gorm.");
                Console.WriteLine("");
                gormsaved = true;
                Typewrite("Gorm is thankful to you for saving him but doesn't look to be mourning the loss of brother. Gorm now pledges his eleagence to you and your cause.");
                Console.WriteLine("");
            }
            else
            {

                // Change colour to blue
                Console.ForegroundColor = ConsoleColor.Blue;
                Typewrite("your story has been changed.");
                Console.WriteLine("");
                // Change colour to white
                Console.ForegroundColor = ConsoleColor.White;
                Typewrite("You run over to Birger and fight the man pinning him to the floor.");
                battle(5, 20);
                Typewrite("After killing him you help Birger to his feet and go to try and save his brother. Birger charges in and is able to stop the viking from killing his brother Gorm but in the proses Birger is fatally wounded and proseasds to die. Gorm is saved by Birger.");
                Console.WriteLine("");
              
                gormsaved = false;
                Typewrite("Gorm is taken aback because for the longest time him and his brother seemed to hate eachother for their entire lives but yet Birger decided to give his life for his brothers. However Gorm will remeber that you left him to die.");
                Console.WriteLine("");
            }
            Typewrite("Bjørn the brutal's raiding party leaves your village with most of your village's supplies to head back to their village. As tee remnents of your village recoupe you see that over half of your village was slatered in the raid. Do you try and rally the rest and try and convise people to join you in revenge(1) or do you use your new role as jarl now that your father passed to make people join you in a revenge raid(2).");
            Console.WriteLine("");
            choice = (int)Value();
            if (choice == 1)
            {

                // Change colour to blue
                Console.ForegroundColor = ConsoleColor.Blue;
                Typewrite("your story has been changed.");
                Console.WriteLine("");
                // Change colour to white
                Console.ForegroundColor = ConsoleColor.White;
                Typewrite("You give a rallying speech to the rest of your village however not everyone is on board with the idea as there will be more of them so some people deside to stay behind but most people do go with you.");
                Console.WriteLine("");
                respect = true;
            }
            else
            {

                // Change colour to blue
                Console.ForegroundColor = ConsoleColor.Blue;
                Typewrite("your story has been changed.");
                Console.WriteLine("");
                // Change colour to white
                Console.ForegroundColor = ConsoleColor.White;
                Typewrite("Rather than giving a speech to try and rally people to your cause you instead make peope come with you as you're now the new jarl but this make most people go with you but they don't respect the cause.");
                Console.WriteLine("");
                respect = false;
            }
            Typewrite("As you and your men treck past the mountains you see a village do you want to do? Do you want to raid the village for better wepons(1)or ignore it all together and keep going to the village of Bjørn the brutal(2)");
            Console.WriteLine("");
            choice = (int)Value();
            if (choice == 1)
            {

                // Change colour to blue
                Console.ForegroundColor = ConsoleColor.Blue;
                Typewrite("your story has been changed.");
                Console.WriteLine("");
                // Change colour to white
                Console.ForegroundColor = ConsoleColor.White;
                Typewrite("As you and your men charge towards the village you meet little opposition and are have to fight someone as that charge towards you.");
                Console.WriteLine("");
                battle(5, 20);
                Typewrite("One defeated two to go.");
                Console.WriteLine("");
                battle(5, 20);
                Typewrite("Two defeated one to go.");
                Console.WriteLine("");
                battle(5, 20);
                Typewrite("You mange to defeate everyone that stands in your way and you make it to the village leader and dispatch of him easily and are able to steal all of the villages resourses and walk back towards the village of Bjørn the brutal.");
                Console.WriteLine("");
                raided = true;
            }
            else
            {

                // Change colour to blue
                Console.ForegroundColor = ConsoleColor.Blue;
                Typewrite("your story has been changed.");
                Console.WriteLine("");
                // Change colour to white
                Console.ForegroundColor = ConsoleColor.White;
                Typewrite("You deside that it would be better as you already have less men than Bjørn the brutal it will be better to not risk loosing your men and that it will be better to have more men than better weapons so you make your way to the village of Bjørn the bruta.");
                Console.WriteLine("");
                raided = false;
            }
            Typewrite("You arrive at the town of Bjørn the brutal, finnalally able to get your revenge for your fallen father but as you make it to the village your past action catch up with you and people start to seem uneasy ...");
            Console.WriteLine("");
            if (gormsaved == true)
            {
                Typewrite("As you saved Gorm during the raid he stands tall with you as you walk into the village.");
                Console.WriteLine("");
                if (respect == true)
                {
                    Typewrite("As you gained the respect of your village they don't falter and leve you and they prepare to face off against Bjørn the brutal and his village.");
                    Console.WriteLine("");
                    if (raided == true)
                    {
                        Typewrite("As you raided the village you have less men at your disposal so you have to fight off more of the opposing village beore you can reach Bjørn the brutal but atleast you have got better weapons.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("One defeated three to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("Two defeated two to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("Three defeated one to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("All enemies have been defeated.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Typewrite("As you ignored the village You don't have better weapons but you do have more men with you so you will need to take on less men yourself.");
                        Console.WriteLine("");
                        battle(5, 20);
                        Typewrite("One defeated two to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("Two defeated one to go.");
                        Console.WriteLine("");
                        battle(5, 20);
                        Typewrite("All enemies have been defeated.");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Typewrite("As you used your power as the new jarl to command people to join you in getting revenge the people who arn't commit to the cause defect and run away so you are left with less people to fight with you.");
                    Console.WriteLine("");
                    if (raided == true)
                    {
                        Typewrite("As you raided the village you have less men at your disposal so you have to fight off more of the opposing village beore you can reach Bjørn the brutal but atleast you have got better weapons.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("One defeated five to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("Two defeated four to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("Three defeated three to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("Four defeated two to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("Five defeated one to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("All the enemies have been defeated.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Typewrite("As you ignored the village You don't have better weapons but you do have more men with you so you will need to take on less men yourself.");
                        Console.WriteLine("");
                        battle(5, 20);
                        Typewrite("One defeated Three to go.");
                        Console.WriteLine("");
                        battle(5, 20);
                        Typewrite("Two defeated two to go.");
                        Console.WriteLine("");
                        battle(5, 20);
                        Typewrite("Three defeated one to go.");
                        Console.WriteLine("");
                        battle(5, 20);
                        Typewrite("All the enemies have been defeated.");
                        Console.WriteLine("");
                    }
                }
            }
            else
            {
                Typewrite("As you left Gorm to die during the initial raid at the start of the game he doesn't want to stand with you so goes over to join Bjørn the brutal to get his revenge agains you.");
                Console.WriteLine("");
                if (respect == true)
                {
                    Typewrite("As you gained the respect of your village they don't falter and leve you and they prepare to face off against Bjørn the brutal and his village.");
                    Console.WriteLine("");
                    if (raided == true)
                    {
                        Typewrite("As you raided the village you have less men at your disposal so you have to fight off more of the opposing village beore you can reach Bjørn the brutal but atleast you have got better weapons.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("One defeated Three to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("Two defeated two to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("Three defeated one to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("All the enemies have been defeated.");
                        Console.WriteLine("");
                        // Gorm boss fight
                        Typewrite("As you finnish off killing all the vikings Gorm steps forward and charges towards you.");
                        Console.WriteLine("");
                        battle(8, 30);
                        Typewrite("You kill Gorm and hold him in your arms as he passes on to Valhalla.");
                        Console.WriteLine("");

                    }
                    else
                    {
                        Typewrite("As you ignored the village You don't have better weapons but you do have more men with you so you will need to take on less men yourself.");
                        Console.WriteLine("");
                        battle(5, 20);
                        Typewrite("One defeated two to go.");
                        Console.WriteLine("");
                        battle(5, 20);
                        Typewrite("Two defeated one to go.");
                        Console.WriteLine("");
                        battle(5, 20);
                        Typewrite("All the enemies have been defeated.");
                        Console.WriteLine("");
                        // Gorm boss fight
                        Typewrite("As you finnish off killing all the vikings Gorm steps forward and charges towards you.");
                        Console.WriteLine("");
                        battle(5, 30);
                        Typewrite("You kill Gorm and hold him in your arms as he passes on to Valhalla.");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Typewrite("As you used your power as the new jarl to command people to join you in getting revenge the people who arn't commit to the cause defect and run away so you are left with less people to fight with you.");
                    Console.WriteLine("");
                    if (raided == true)
                    {
                        Typewrite("As you raided the village you have less men at your disposal so you have to fight off more of the opposing village beore you can reach Bjørn the brutal but atleast you have got better weapons.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("One defeated five to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("Two defeated four to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("Three defeated three to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("Four defeated two to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("Five defeated one to go.");
                        Console.WriteLine("");
                        battle(8, 20);
                        Typewrite("All the enemies have been defeated.");
                        Console.WriteLine("");
                        // Gorm boss fight
                        Typewrite("As you finnish off killing all the vikings Gorm steps forward and charges towards you.");
                        Console.WriteLine("");
                        battle(8, 30);
                        Typewrite("You kill Gorm and hold him in your arms as he passes on to Valhalla.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Typewrite("As you ignored the village You don't have better weapons but you do have more men with you so you will need to take on less men yourself.");
                        Console.WriteLine("");
                        battle(5, 20);
                        Typewrite("One defeated Three to go.");
                        Console.WriteLine("");
                        battle(5, 20);
                        Typewrite("Two defeated two to go.");
                        Console.WriteLine("");
                        battle(5, 20);
                        Typewrite("Three defeated one to go.");
                        Console.WriteLine("");
                        battle(5, 20);
                        Typewrite("All the enemies have been defeated.");
                        Console.WriteLine("");
                        // Gorm boss fight
                        Typewrite("As you finnish off killing all the vikings Gorm steps forward and charges towards you.");
                        Console.WriteLine("");
                        Typewrite("As you finnish off killing all the vikings Gorm steps forward and charges towards you.");
                        Console.WriteLine("");
                        battle(5, 30);
                        Typewrite("You kill Gorm and hold him in your arms as he passes on to Valhalla.");
                        Console.WriteLine("");
                    }
                }
            }
            if (raided == true)
            {
                Typewrite("You finish off all of Bjørn the brutal's men and now there's nothing left between the two of you so you start the fight to the death.");
                Console.WriteLine("");
                battle(8, 35);
                Typewrite("You have beaten Bjørn the brutal and your vikings quest for revenge has ended sucssefully");
                Console.WriteLine("");
            }
            else
            {
                Typewrite("You finish off all of Bjørn the brutal's men and now there's nothing left between the two of you so you start the fight to the death.");
                Console.WriteLine("");
                battle(5, 35);
                Typewrite("You have beaten Bjørn the brutal and your vikings quest for revenge has ended sucssefully");
                Console.WriteLine("");
                Console.WriteLine(@"  
                                 .-'`-.
                                /  | | \
                               /   | |  \
                              |  __|_|___|
                              |' ||| ||| |
                              |(   _L   )|
                              \|`-'__`-' |'
                               |  `--'   |
                              _|         |-.
                          .-'| |  \     /  `-.
                         /   | |\     .'      `-.
                        /    | | `''''           \
                       J     | |             _____|
                       |  |  J J         .-'   ___ `-.
                       |  \   L L      .'  .-'  |  `-.`.
                       | \|   | |     /  .'|    |    |\ \
                       |  |   J J   .' .'  |    |    | \ \
                       |  |    L L J  /    |    |    |  \ L
                      /   |     \ \F J|    |    |    |   LJ
                      |   |      \J F | () | () | () | ()| L
                     J  \ |       FJ  |    |  / _`-. |   J |
                     |    |      J |  |    | //    \ |   J |
                    J     |\     | |  |    ||:(     ||   J |
                    |     | `----| |  |    ||::`._.:||   | F
                    |     /\_    | |  |    ||:::::::F|   | F
                    |    |  /`---| |  |    | \:::::/ |   FJ
                    F    |  / |  J |  |    |  `-:-'  |  J F
                   J_.--/  /  |  J J  | () | () | () |()FJ
                    |  |    /     L L |    |    |    | / F
                    |  |     |    \ \ |    |    |    |/ /
                  |`-. |    |     |\ \|    |    |    / /
                  J'\ \|    |     | `.`.   |    |  .'.'
                 / .'> |    |     |  `-.`-.|____.-'.'
               .' /::'_|    |/    |    `-.______.-'
              / .::/   \    |     |           |  |
            .' /::'     |--._     |           |--|
           / .::/       |    `-.__|     ____.-|//|
         .' /::'        |        F `--'      ||< |
        / .::/          |       J   |        FL\\|
      .' /::'           )       |   |        F| >|
     / .::/            (        \   |        F|//|
   .' /::'              \       /   |        F|--|
  / .::/                 |` `' '(   (      ' J|  |
 | /::'                  |  | ` \   \  `    / J  |
 |_:/                    |  | | |    |`-  ''F J  J
                         |    ' F    |      |  `-'
                         |     J     |      |
                         |     /     |      |
                         |   .'      |      F
                        /---'(       J     J
                      .'     \        L    |
                   .-'        )       L    F
                 .'       .---'       \__.-'
                (       .'             L   |
                 `-----'               |   \
                                       J    \
                                        L    L
                                        |    F
                                        `-.-'");
                
            }
        }


    }



    static void battle(int pstrengh, int cpuhealth)
    {
        int cpuhitpos;
        int hitpos;
        int cpudef;
        string playerhitpos;
        playerhitpos = "hi";
        hitpos = 0;
        int playerdmg;

        playerdmg = pstrengh;
        double cpuhp;

        cpuhp = cpuhealth;
        double playeracdmg;
        double playerhp;

        playerhp = 30;
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

                Console.Write(Environment.NewLine);
                Console.Write(Environment.NewLine);
                Console.WriteLine(" Your health is: ");
                ProgressBar(Convert.ToInt32(playerhp), 30);
                Console.Write(Environment.NewLine);
                if (playerhp == 0)
                {
                    Console.WriteLine("You have been defeated.");
                    break;
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
                Console.Write(Environment.NewLine);
                Console.Write(Environment.NewLine);
                Console.WriteLine(" Your enemy is: ");
                ProgressBar(Convert.ToInt32(cpuhp), cpuhealth);
                Console.Write(Environment.NewLine);
                if (cpuhp == 0)
                {
                    Console.WriteLine("You defeated the enemy.");
                    break;
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
                Console.Write(Environment.NewLine);
                Console.Write(Environment.NewLine);
                Console.WriteLine(" Your enemy is: ");
                ProgressBar(Convert.ToInt32(cpuhp), cpuhealth);
                Console.Write(Environment.NewLine);
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
                Console.Write(Environment.NewLine);
                Console.Write(Environment.NewLine);
                Console.WriteLine(" Your health is: ");
                ProgressBar(Convert.ToInt32(playerhp), 30);
                Console.Write(Environment.NewLine);
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
    private static double Value()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

    private static void ProgressBar(int progress, int tot)
    {
        //draw empty progress bar
        Console.CursorLeft = 0;
        Console.Write(" "); //start
        Console.CursorLeft = 32;
        Console.Write(" "); //end
        Console.CursorLeft = 1;
        float onechunk = 30.0f / tot;

        //draw filled part
        int position = 1;
        for (int i = 0; i < onechunk * progress; i++)
        {
            if (progress < 5)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (progress > 10)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }

            Console.CursorLeft = position++;
            Console.Write(" ");
        }

        //draw unfilled part
        for (int i = position; i <= 31; i++)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.CursorLeft = position++;
            Console.Write(" ");
        }

        //draw totals
        Console.CursorLeft = 35;
        Console.ResetColor();
        //Console.BackgroundColor = ConsoleColor.Black;
        Console.Write("(" + progress.ToString() + " of " + tot.ToString() + ")");

    }

    static void Typewrite(string message)
    {
        for (int i = 0; i < message.Length; i++)
        {
            Console.Write(message[i]);
            System.Threading.Thread.Sleep(40);
        }


    }

}
