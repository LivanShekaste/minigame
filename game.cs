using System.Collections;
using System.ComponentModel;
using System.Net.Security;
using System.Numerics;

Random rand = new Random();
bool playagain = true;
string lp = "| Type P to Use Luck Potion | ";
string rtd = "Press Enter to roll the dice ";
string lpu = "[L]=* Luck Potion Used! *=[L]";
string potion_3 = " 1. [L]=*  2. [L]=*  3. [L]=* ";
string potion_2 = " 1. [L]=*  2. [L]=* ";
string potion_1 = " 1. [L]=* ";

Console.WriteLine("Enter You Name : ");
string player = Console.ReadLine();
int y = 0;
if (player.Length < 1)
{
    while (y < 1)
    {
        Console.WriteLine("Enter Your Name : ");
        player = Console.ReadLine();
        if (player.Length != 0)
        {
            y++;
        }
    }
}
player = char.ToUpper(player[0]) + player.Substring(1);
Console.WriteLine("Welcome " + player + "!");

while (playagain)
{
    int round = 1;
    int i = 0;
    int j = 0;
    int potion = 3;
    while (i < 2 && j < 2)
    {
        Console.WriteLine("");
        Console.WriteLine("Round " + round);
        int dice = 0;
        int pr1 = rand.Next(1, 7); int pr2 = rand.Next(1, 7); int pr3 = rand.Next(1, 7); int pr4 = rand.Next(1, 7);
        int cr1 = rand.Next(1, 7); int cr2 = rand.Next(1, 7); int cr3 = rand.Next(1, 7); int cr4 = rand.Next(1, 7);
        int dosh1 = rand.Next(2,7); int dosh2 = rand.Next(2, 7); int dosh3 = rand.Next(2, 7); int dosh4 = rand.Next(2, 7);
        int sesh1 = rand.Next(3, 7); int sesh2 = rand.Next(3, 7); int sesh3 = rand.Next(3, 7); int sesh4 = rand.Next(3, 7);
        int charsh1 = rand.Next(5, 7); int charsh2 = rand.Next(5, 7); int charsh3 = rand.Next(5, 7); int charsh4 = rand.Next(5, 7);
        int panjsh1 = rand.Next(6, 7); int panjsh2 = rand.Next(6, 7); int panjsh3 = rand.Next(6, 7); int panjsh4 = rand.Next(6, 7);
        int lp1 = rand.Next(4, 7); int lp2 = rand.Next(4, 7); int lp3 = rand.Next(4, 7);
        int clp1 = rand.Next(5, 7); int clp2 = rand.Next(5, 7); int clp3 = rand.Next(5, 7);
        string pr11 = Convert.ToString(pr1);string pr22 = Convert.ToString(pr2);
        string pr33 = Convert.ToString(pr3); string pr44= Convert.ToString(pr4);
        string cr11 = Convert.ToString(cr1);string cr22 = Convert.ToString(cr2);
        string cr33 = Convert.ToString(cr3);string cr44= Convert.ToString(cr4);

        
        while (dice != 4)
        {   
            if (dice == 0)
            {
                Console.WriteLine("");
                Console.Write(rtd);
                if (potion == 3)
                {
                    Console.WriteLine(lp + potion_3);
                }
                else if (potion == 2)
                {
                    Console.WriteLine(lp + potion_2);
                }
                else if (potion == 1)
                {
                    Console.WriteLine(lp + potion_1);
                }
                string luck = Console.ReadLine();
                luck = luck.ToUpper();
                if (luck == "P" && potion > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine(lpu);
                    Console.Beep();
                    potion--;
                    int potion1 = rand.Next(1,potion + 1);
                    if (potion1 == 1)
                    {
                        pr1 = lp1;
                    }
                    else if (potion1 == 2)
                    {
                        pr1 = lp2;
                    }
                    else
                    {
                        pr1 = lp3;
                    }
                    pr11 = Convert.ToString(pr1);
                }
                else if (luck == "P" && potion == 0)
                {
                    Console.WriteLine("No Potion Left");
                }
                if (player == "Ahmad Pourmokhber")
                {
                    pr1 = panjsh1;
                }
                else if (player.Length > 14 && player.Length < 21)
                {
                    pr1 = dosh1;
                }
                else if (player.Length > 20 && player.Length <31)
                {
                    pr1 = sesh1;
                }
                else if (player.Length == 37)
                {
                    pr1 = charsh1;
                }
                pr11 = Convert.ToString(pr1);
                Console.WriteLine(player + " : " + pr11);
                Console.WriteLine("Computer : " + cr11);
                dice++;
            }
            else if (dice == 1)
            {
                Console.WriteLine("");
                Console.Write(rtd);
                if (potion == 3 )
                {
                    Console.WriteLine(lp + potion_3);
                }
                else if (potion == 2)
                {
                    Console.WriteLine(lp + potion_2);
                }
                else if (potion == 1)
                {
                    Console.WriteLine(lp + potion_1);
                }
                string luck = Console.ReadLine();
                luck = luck.ToUpper();
                if (luck == "P" && potion > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine(lpu);
                    Console.Beep();
                    potion--;
                    int potion1 = rand.Next(1, potion + 1);
                    if (potion1 == 1 )
                    {
                        pr2 = lp1;
                    }
                    else if (potion1 == 2)
                    {
                        pr2 = lp2;
                    }
                    else
                    {
                        pr2 = lp3;
                    }
                    pr22 = Convert.ToString(pr2);
                }
                else if (luck == "P" && potion == 0)
                {
                    Console.WriteLine("No Potion Left");
                }
                if (player == "Ahmad Pourmokhber")
                {
                    pr2 = panjsh2;
                }
                else if (player.Length > 14 && player.Length < 21)
                {
                    pr2 = dosh2;
                }
                else if (player.Length > 20 && player.Length < 31)
                {
                    pr2 = sesh2;
                }
                else if (player.Length == 37)
                {
                    pr2 = charsh2;
                }
                pr22 = Convert.ToString(pr2);
                Console.WriteLine(player + " : " + pr11 + " - " + pr22 + " - " + "[" + (pr1 + pr2) + "]");
                Console.WriteLine("Computer : " + cr11 + " - " + cr22 + " - " + "[" + (cr1 + cr2) + "]");
                dice++;
            }
            else if (dice == 2)
            {
                Console.WriteLine("");
                Console.Write(rtd);
                if (potion == 3)
                {
                    Console.WriteLine(lp + potion_3);
                }
                else if (potion == 2)
                {
                    Console.WriteLine(lp + potion_2);
                }
                else if (potion == 1)
                {
                    Console.WriteLine(lp + potion_1);
                }
                string luck = Console.ReadLine();
                luck = luck.ToUpper();
                if (luck == "P" && potion > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine(lpu);
                    Console.Beep();
                    potion--;
                    int potion1 = rand.Next(1, potion + 1);
                    if (potion1 == 1)
                    {
                        pr3 = lp1;
                    }
                    else if (potion1 == 2)
                    {
                        pr3 = lp2;
                    }
                    else
                    {
                        pr3 = lp3;
                    }
                    pr33 = Convert.ToString(pr3);
                }
                else if (luck == "P" && potion == 0)
                {
                    Console.WriteLine("No Potion Left");
                }
                if (player == "Ahmad Pourmokhber")
                {
                    pr3 = panjsh3;
                }
                else if (player.Length > 14 && player.Length < 21)
                {
                    pr3 = dosh3;
                }
                else if (player.Length > 20 && player.Length < 31)
                {
                    pr3 = sesh3;
                }
                else if (player.Length == 37)
                {
                    pr3 = charsh3;
                } 
                pr33 = Convert.ToString(pr3);
                Console.WriteLine(player + " : " + pr11 + " - " + pr22 + " - " + pr33 + " - " + "[" + (pr1 + pr2 + pr3) + "]");
                Console.WriteLine("Computer : " + cr11 + " - " + cr22 + " - " + cr33 + " - " + "[" + (cr1 + cr2 + cr3) + "]");
                dice++;
            }
            else if (dice == 3)
            {
                Console.WriteLine("");
                Console.Write(rtd);
                if (potion == 3)
                {
                    Console.WriteLine(lp + potion_3);
                }
                else if (potion == 2)
                {
                    Console.WriteLine(lp + potion_2);
                }
                else if (potion == 1)
                {
                    Console.WriteLine(lp + potion_1);
                };
                string luck = Console.ReadLine();
                luck = luck.ToUpper();
                if (luck == "P" && potion > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine(lpu);
                    Console.Beep();
                    potion--;
                    int potion1 = rand.Next(1, potion + 1);
                    if (potion1 == 1)
                    {
                        pr4 = lp1;
                    }
                    else if (potion1 == 2)
                    {
                        pr4 = lp2;
                    }
                    else
                    {
                        pr4 = lp3;
                    }
                    pr44 = Convert.ToString(pr4);
                }
                else if (luck == "P" &&  potion == 0)
                {
                    Console.WriteLine("No Potion Left");
                }
                if (player == "Ahmad Pourmokhber")
                {
                    pr4 = panjsh4;
                }
                else if (player.Length > 14 && player.Length < 21)
                {
                    pr4 = dosh4;
                }
                else if (player.Length > 20 && player.Length < 31)
                {
                    pr4 = sesh4;
                }
                else if (player.Length == 37)
                {
                    pr4 = charsh4;
                }
                pr44 = Convert.ToString(pr4);
                Console.WriteLine(player + " : " + pr11 + " - " + pr22 + " - " + pr33 + " - " + pr44 + " - " + "[" + (pr1 + pr2 + pr3 + pr4) + "]");
                int kaftar = rand.Next(1, 4);
                if (kaftar == 1)
                {
                    cr4 = clp1;
                }
                else if (kaftar == 2)
                {
                    cr4 = clp2;
                }
                else
                {
                    cr4 = clp3;
                }
                cr44 = Convert.ToString(cr4);
                Console.WriteLine("Computer : " + cr11 + " - " + cr22 + " - " + cr33 + " - " + cr44 + " - " + "[" + (cr1 + cr2 + cr3 + cr4) + "]");
                Console.WriteLine("");
                dice++;
            }
        }
        int pr = pr1 + pr2 + pr3 + pr4;
        int cr = cr1 + cr2 + cr3 + cr4;
        if (pr > cr)
        {
            Console.WriteLine($"=={player} Win Round!({round})==");
            i += 1;
            round += 1;
            Console.WriteLine($"=={player} ({i}) VS Computer ({j})==");
        }
        else if (pr < cr)
        {
            Console.WriteLine($"==Computer Win Round!({round})==");
            j += 1;
            round += 1;
            Console.WriteLine($"=={player} ({i}) VS Computer ({j})==");
        }
        else
        {
            Console.WriteLine("==Draw==");
            round += 1;
            Console.WriteLine($"=={player} ({i}) VS Computer ({j})==");
        }



    }
    if (i == 2)
    {
        Console.WriteLine("");
        Console.WriteLine("\\ \\ \\ \"" + player + " WIN!\" / / / ");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("\\ \\ \\ \"Computer WIN!\" / / / ");
    }



    int x = 0;
        while (x < 1)
        {
        Console.WriteLine("");
            Console.WriteLine("Do you want to play again ? (type Y for Yes or N for No) :");
            string pizza = Console.ReadLine();
            pizza = pizza.ToUpper();
            if (pizza == "Y")
            {
                playagain = true;
            x++;
            }
            else if (pizza == "N")
            {
                playagain = false;
            x++;
        }
        else
        {
            Console.WriteLine("Type Y or N");

        }
    }
   
}


Console.ReadKey();