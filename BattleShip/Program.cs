using System;
using System.Linq;

namespace Program
{
    class BattleShip
    {
        static void Main(string[] args)
        {
            int count;
            int[,] playerGameZone = new int[10, 10];
            int[,] enemyGameZone =
            {
                {1, 0, 0, 0, 0, 1, 1, 1, 0, 0},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 1, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
                {0, 0, 1, 0, 0, 0, 1, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 1, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
                {0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 1, 1, 1, 0, 0, 0}
            };

            Console.WriteLine("Для начала короткая инструкция:\n\n(О) - пустое место;\n(~) - место, ка котором располагается корабль;\n(*) - место, куда Вы уже стреляли;\n(X) - попадание по кораблю.\n\nНажмите Enter для продолжения...");
            Console.ReadLine();
            Console.Clear();

            string[,] visualSituation = new string[10, 10];
            Console.WriteLine("Игровое поле:\n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (playerGameZone[i, j] == 0)
                        visualSituation[i, j] = "O";
                    else if(playerGameZone[i, j] == 1)
                        visualSituation[i, j] = "~";
                    else if(playerGameZone[i, j] == 2)
                        visualSituation[i, j] = "*";
                    Console.Write(visualSituation[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nРасположите 1-й однопалубный корабль.\n\nВведите горизонтальную ось..."); // Расположение 1-палубного корабля
            int horyzontally = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            int vertically = int.Parse(Console.ReadLine());
            horyzontally--; vertically--;
            playerGameZone[vertically, horyzontally] = 1;
            Console.Clear();


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (playerGameZone[i, j] == 0)
                        visualSituation[i, j] = "O";
                    else if (playerGameZone[i, j] == 1)
                        visualSituation[i, j] = "~";
                    else if (playerGameZone[i, j] == 2)
                        visualSituation[i, j] = "*";
                    Console.Write(visualSituation[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nРасположите 2-й однопалубный корабль.\n\nВведите горизонтальную ось..."); // Расположение 1-палубного корабля
            horyzontally = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically = int.Parse(Console.ReadLine());
            horyzontally--; vertically--;
            if(playerGameZone[vertically, horyzontally] != 1)
                playerGameZone[vertically, horyzontally] = 1;
            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (playerGameZone[i, j] == 0)
                        visualSituation[i, j] = "O";
                    else if (playerGameZone[i, j] == 1)
                        visualSituation[i, j] = "~";
                    else if (playerGameZone[i, j] == 2)
                        visualSituation[i, j] = "*";
                    Console.Write(visualSituation[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nРасположите 3-й однопалубный корабль.\n\nВведите горизонтальную ось..."); // Расположение 1-палубного корабля
            horyzontally = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically = int.Parse(Console.ReadLine());
            horyzontally--; vertically--;
            if (playerGameZone[vertically, horyzontally] != 1)
                playerGameZone[vertically, horyzontally] = 1;
            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (playerGameZone[i, j] == 0)
                        visualSituation[i, j] = "O";
                    else if (playerGameZone[i, j] == 1)
                        visualSituation[i, j] = "~";
                    else if (playerGameZone[i, j] == 2)
                        visualSituation[i, j] = "*";
                    Console.Write(visualSituation[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nРасположите 4-й однопалубный корабль.\n\nВведите горизонтальную ось..."); // Расположение 1-палубного корабля
            horyzontally = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically = int.Parse(Console.ReadLine());
            horyzontally--; vertically--;
            if (playerGameZone[vertically, horyzontally] != 1)
                playerGameZone[vertically, horyzontally] = 1;
            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (playerGameZone[i, j] == 0)
                        visualSituation[i, j] = "O";
                    else if (playerGameZone[i, j] == 1)
                        visualSituation[i, j] = "~";
                    else if (playerGameZone[i, j] == 2)
                        visualSituation[i, j] = "*";
                    Console.Write(visualSituation[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nРасположите 1-й двухпалубный корабль.\n\nВведите горизонтальную ось..."); // Расположение 2-палубного корабля
            horyzontally = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically = int.Parse(Console.ReadLine());
            horyzontally--; vertically--;
            if (playerGameZone[vertically, horyzontally] != 1)
                playerGameZone[vertically, horyzontally] = 1;
            Console.WriteLine("Введите горизонтальную ось...");
            int horyzontally_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            int vertically_1 = int.Parse(Console.ReadLine());
            horyzontally_1--; vertically_1--;
            if (horyzontally_1 - horyzontally == 1  || horyzontally_1 - horyzontally == -1 && vertically_1 - vertically == 0 && playerGameZone[vertically_1, horyzontally_1] != 1)
                playerGameZone[vertically_1, horyzontally_1] = 1;
            else if(vertically_1 - vertically == 1 || vertically_1 - vertically == -1 && horyzontally_1 - horyzontally == 0 && playerGameZone[vertically_1, horyzontally_1] != 1)
                playerGameZone[vertically_1, horyzontally_1] = 1;
            else
                playerGameZone[vertically, horyzontally] = 0;
            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (playerGameZone[i, j] == 0)
                        visualSituation[i, j] = "O";
                    else if (playerGameZone[i, j] == 1)
                        visualSituation[i, j] = "~";
                    else if (playerGameZone[i, j] == 2)
                        visualSituation[i, j] = "*";
                    Console.Write(visualSituation[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nРасположите 2-й двухпалубный корабль.\n\nВведите горизонтальную ось..."); // Расположение 2-палубного корабля
            horyzontally = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically = int.Parse(Console.ReadLine());
            horyzontally--; vertically--;
            if (playerGameZone[vertically, horyzontally] != 1)
                playerGameZone[vertically, horyzontally] = 1;
            Console.WriteLine("Введите горизонтальную ось...");
            horyzontally_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically_1 = int.Parse(Console.ReadLine());
            horyzontally_1--; vertically_1--;
            if (horyzontally_1 - horyzontally == 1 || horyzontally_1 - horyzontally == -1 && vertically_1 - vertically == 0 && playerGameZone[vertically_1, horyzontally_1] != 1)
                playerGameZone[vertically_1, horyzontally_1] = 1;
            else if (vertically_1 - vertically == 1 || vertically_1 - vertically == -1 && horyzontally_1 - horyzontally == 0 && playerGameZone[vertically_1, horyzontally_1] != 1)
                playerGameZone[vertically_1, horyzontally_1] = 1;
            else
                playerGameZone[vertically, horyzontally] = 0;
            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (playerGameZone[i, j] == 0)
                        visualSituation[i, j] = "O";
                    else if (playerGameZone[i, j] == 1)
                        visualSituation[i, j] = "~";
                    else if (playerGameZone[i, j] == 2)
                        visualSituation[i, j] = "*";
                    Console.Write(visualSituation[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nРасположите 3-й двухпалубный корабль.\n\nВведите горизонтальную ось..."); // Расположение 2-палубного корабля
            horyzontally = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically = int.Parse(Console.ReadLine());
            horyzontally--; vertically--;
            if (playerGameZone[vertically, horyzontally] != 1)
                playerGameZone[vertically, horyzontally] = 1;
            Console.WriteLine("Введите горизонтальную ось...");
            horyzontally_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically_1 = int.Parse(Console.ReadLine());
            horyzontally_1--; vertically_1--;
            if (horyzontally_1 - horyzontally == 1 || horyzontally_1 - horyzontally == -1 && vertically_1 - vertically == 0 && playerGameZone[vertically_1, horyzontally_1] != 1)
                playerGameZone[vertically_1, horyzontally_1] = 1;
            else if (vertically_1 - vertically == 1 || vertically_1 - vertically == -1 && horyzontally_1 - horyzontally == 0 && playerGameZone[vertically_1, horyzontally_1] != 1)
                playerGameZone[vertically_1, horyzontally_1] = 1;
            else
                playerGameZone[vertically, horyzontally] = 0;
            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (playerGameZone[i, j] == 0)
                        visualSituation[i, j] = "O";
                    else if (playerGameZone[i, j] == 1)
                        visualSituation[i, j] = "~";
                    else if (playerGameZone[i, j] == 2)
                        visualSituation[i, j] = "*";
                    Console.Write(visualSituation[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nРасположите 1-й трехпалубный корабль.\n\nВведите горизонтальную ось..."); // Расположение 3-палубного корабля
            horyzontally = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically = int.Parse(Console.ReadLine());
            horyzontally--; vertically--;
            if (playerGameZone[vertically, horyzontally] != 1)
                playerGameZone[vertically, horyzontally] = 1;
            Console.WriteLine("Введите горизонтальную ось..."); // Вторая палуба
            horyzontally_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically_1 = int.Parse(Console.ReadLine());
            horyzontally_1--; vertically_1--;
            if (horyzontally_1 - horyzontally == 1 || horyzontally_1 - horyzontally == -1 && vertically_1 - vertically == 0 && playerGameZone[vertically_1, horyzontally_1] != 1)
                playerGameZone[vertically_1, horyzontally_1] = 1;
            else if (vertically_1 - vertically == 1 || vertically_1 - vertically == -1 && horyzontally_1 - horyzontally == 0 && playerGameZone[vertically_1, horyzontally_1] != 1)
                playerGameZone[vertically_1, horyzontally_1] = 1;
            else
                playerGameZone[vertically, horyzontally] = 0;
            Console.WriteLine("Введите горизонтальную ось..."); // Третья палуба
            int horyzontally_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            int vertically_2 = int.Parse(Console.ReadLine());
            horyzontally_2--; vertically_2--;
            if (horyzontally_2 - horyzontally_1 == 1 || horyzontally_2 - horyzontally_1 == -1 && vertically_2 - vertically_1 == 0 && playerGameZone[vertically_2, horyzontally_2] != 1)
                playerGameZone[vertically_2, horyzontally_2] = 1;
            else if (vertically_2 - vertically_1 == 1 || vertically_2 - vertically_1 == -1 && horyzontally_2 - horyzontally_1 == 0 && playerGameZone[vertically_2, horyzontally_2] != 1)
                playerGameZone[vertically_2, horyzontally_2] = 1;
            else
            {
                playerGameZone[vertically, horyzontally] = 0;
                playerGameZone[vertically_1, horyzontally_1] = 0;
            }
            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (playerGameZone[i, j] == 0)
                        visualSituation[i, j] = "O";
                    else if (playerGameZone[i, j] == 1)
                        visualSituation[i, j] = "~";
                    else if (playerGameZone[i, j] == 2)
                        visualSituation[i, j] = "*";
                    Console.Write(visualSituation[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nРасположите 2-й трехпалубный корабль.\n\nВведите горизонтальную ось..."); // Расположение 3-палубного корабля
            horyzontally = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically = int.Parse(Console.ReadLine());
            horyzontally--; vertically--;
            if (playerGameZone[vertically, horyzontally] != 1)
                playerGameZone[vertically, horyzontally] = 1;
            Console.WriteLine("Введите горизонтальную ось..."); // Вторая палуба
            horyzontally_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically_1 = int.Parse(Console.ReadLine());
            horyzontally_1--; vertically_1--;
            if (horyzontally_1 - horyzontally == 1 || horyzontally_1 - horyzontally == -1 && vertically_1 - vertically == 0 && playerGameZone[vertically_1, horyzontally_1] != 1)
                playerGameZone[vertically_1, horyzontally_1] = 1;
            else if (vertically_1 - vertically == 1 || vertically_1 - vertically == -1 && horyzontally_1 - horyzontally == 0 && playerGameZone[vertically_1, horyzontally_1] != 1)
                playerGameZone[vertically_1, horyzontally_1] = 1;
            else
                playerGameZone[vertically, horyzontally] = 0;
            Console.WriteLine("Введите горизонтальную ось..."); // Третья палуба
            horyzontally_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically_2 = int.Parse(Console.ReadLine());
            horyzontally_2--; vertically_2--;
            if (horyzontally_2 - horyzontally_1 == 1 || horyzontally_2 - horyzontally_1 == -1 && vertically_2 - vertically_1 == 0 && playerGameZone[vertically_2, horyzontally_2] != 1)
                playerGameZone[vertically_2, horyzontally_2] = 1;
            else if (vertically_2 - vertically_1 == 1 || vertically_2 - vertically_1 == -1 && horyzontally_2 - horyzontally_1 == 0 && playerGameZone[vertically_2, horyzontally_2] != 1)
                playerGameZone[vertically_2, horyzontally_2] = 1;
            else
            {
                playerGameZone[vertically, horyzontally] = 0;
                playerGameZone[vertically_1, horyzontally_1] = 0;
            }
            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (playerGameZone[i, j] == 0)
                        visualSituation[i, j] = "O";
                    else if (playerGameZone[i, j] == 1)
                        visualSituation[i, j] = "~";
                    else if (playerGameZone[i, j] == 2)
                        visualSituation[i, j] = "*";
                    Console.Write(visualSituation[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nРасположите четырехпалубный корабль.\n\nВведите горизонтальную ось..."); // Расположение 4-палубного корабля
            horyzontally = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically = int.Parse(Console.ReadLine());
            horyzontally--; vertically--;
            if (playerGameZone[vertically, horyzontally] != 1)
                playerGameZone[vertically, horyzontally] = 1;
            Console.WriteLine("Введите горизонтальную ось..."); // Вторая палуба
            horyzontally_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically_1 = int.Parse(Console.ReadLine());
            horyzontally_1--; vertically_1--;
            if (horyzontally_1 - horyzontally == 1 || horyzontally_1 - horyzontally == -1 && vertically_1 - vertically == 0 && playerGameZone[vertically_1, horyzontally_1] != 1)
                playerGameZone[vertically_1, horyzontally_1] = 1;
            else if (vertically_1 - vertically == 1 || vertically_1 - vertically == -1 && horyzontally_1 - horyzontally == 0 && playerGameZone[vertically_1, horyzontally_1] != 1)
                playerGameZone[vertically_1, horyzontally_1] = 1;
            else
                playerGameZone[vertically, horyzontally] = 0;
            Console.WriteLine("Введите горизонтальную ось..."); // Третья палуба
            horyzontally_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            vertically_2 = int.Parse(Console.ReadLine());
            horyzontally_2--; vertically_2--;
            if (horyzontally_2 - horyzontally_1 == 1 || horyzontally_2 - horyzontally_1 == -1 && vertically_2 - vertically_1 == 0 && playerGameZone[vertically_2, horyzontally_2] != 1)
                playerGameZone[vertically_2, horyzontally_2] = 1;
            else if (vertically_2 - vertically_1 == 1 || vertically_2 - vertically_1 == -1 && horyzontally_2 - horyzontally_1 == 0 && playerGameZone[vertically_2, horyzontally_2] != 1)
                playerGameZone[vertically_2, horyzontally_2] = 1;
            else
            {
                playerGameZone[vertically, horyzontally] = 0;
                playerGameZone[vertically_1, horyzontally_1] = 0;
            }
            Console.WriteLine("Введите горизонтальную ось..."); // Четвертая палуба
            int horyzontally_3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вертикальную ось...");
            int vertically_3 = int.Parse(Console.ReadLine());
            horyzontally_3--; vertically_3--;
            if (horyzontally_3 - horyzontally_2 == 1 || horyzontally_3 - horyzontally_2 == -1 && vertically_3 - vertically_2 == 0 && playerGameZone[vertically_3, horyzontally_3] != 1)
                playerGameZone[vertically_3, horyzontally_3] = 1;
            else if (vertically_3 - vertically_2 == 1 || vertically_3 - vertically_2 == -1 && horyzontally_3 - horyzontally_2 == 0 && playerGameZone[vertically_3, horyzontally_3] != 1)
                playerGameZone[vertically_3, horyzontally_3] = 1;
            else
            {
                playerGameZone[vertically, horyzontally] = 0;
                playerGameZone[vertically_1, horyzontally_1] = 0;
                playerGameZone[vertically_2, horyzontally_2] = 0;
            }
            Console.Clear();
            

            Console.WriteLine("Ваше поле выглядит так:\n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write(visualSituation[i, j] + "\t");
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nНажмите Enter для продолжения...");
            Console.ReadLine();

            bool move = false, arr = false, theEnd = false, theEndEnemy = false;
            Random random = new Random();
            int a = 0, b = 0, k = 0, l = 0;
            int[,] enemyMove = new int[10, 10];
            string[,] enemySituation = new string[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    enemySituation[i, j] = "O";
                }
            }
            do
            {
                for (bool miss = false; !miss;)
                {
                    Console.Clear();
                    Console.WriteLine("Ваше поле с ходами противника:\n"); // Вывод поля игрока
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                            Console.Write(visualSituation[i, j] + "\t");
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("Поле противника с Вашими ходами:\n"); // Вывод поля игрока
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                            Console.Write(enemySituation[i, j] + "\t");
                        Console.WriteLine("\n");
                    }

                    Console.WriteLine("\nВаш ход.\n\nВведите горизонтальную ось..."); // Ход игрока
                    horyzontally = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите вертикальную ось...");
                    vertically = int.Parse(Console.ReadLine());
                    horyzontally--; vertically--;

                    if (enemyGameZone[vertically, horyzontally] == 1)
                    {
                        enemySituation[vertically, horyzontally] = "X";
                        enemyGameZone[vertically, horyzontally] = 2;
                        Console.WriteLine("\nВы попали в корабль противника!");
                        System.Threading.Thread.Sleep(3000);
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (enemyGameZone[i, j] == 1)
                                {
                                    theEnd = false;
                                    i = 10;
                                    break;
                                }
                                else if (enemyGameZone[i, j] == 0 || enemyGameZone[i, j] == 2)
                                    theEnd = true;
                            }
                        }
                        if (theEnd)
                        {
                            Console.WriteLine("\nВы уничтожили все корабли противника и победили!\n\nКонец игры.");
                            move = true;
                            arr = true;
                            break;
                        }
                        arr = false;
                        miss = false;
                    }
                    else if (enemyGameZone[vertically, horyzontally] == 2)
                    {
                        Console.WriteLine("\nВы уже стреляли в эту точку! Нажмите Enter для продолжения...\n");
                        Console.ReadLine();
                        Console.Clear();
                        miss = true;
                    }
                    else
                    {
                        enemySituation[vertically, horyzontally] = "*";
                        Console.WriteLine("\nМимо! Ожидайте ход противника...");
                        System.Threading.Thread.Sleep(3000);
                        miss = true;
                        arr = false;
                    }
                }

                for(;!arr;) //Ход противника
                {
                    for (bool miss = false; !miss;)
                    {
                        a = random.Next(0, 9);
                        b = random.Next(0, 9);
                        if (enemyMove[b, a] == 0)
                        {
                            miss = false;
                            visualSituation[b, a] = "*";
                            if (playerGameZone[b, a] == 1)
                            {
                                Console.WriteLine("\nПротивник попал в Ваш корабль!");
                                System.Threading.Thread.Sleep(3000);
                                arr = true;
                                visualSituation[b, a] = "X";
                                for (int i = 0; i < 10; i++)
                                {
                                    for (int j = 0; j < 10; j++)
                                    {
                                        if (playerGameZone[i, j] == 1)
                                        {
                                            theEndEnemy = false;
                                            i = 10;
                                            break;
                                        }
                                        else if (enemyGameZone[i, j] == 0 || enemyGameZone[i, j] == 2)
                                            theEndEnemy = true;
                                    }
                                }
                                if (theEndEnemy)
                                {
                                    Console.WriteLine("\nПротивник уничтожил все ваши корабли и победил :(\n\nКонец игры.");
                                    move = true;
                                    arr = true;
                                    miss = true;
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"\nПротивник выстрелил мимо и промахнулся. Нажмите Enter для продолжения...");
                                Console.ReadLine();
                                Console.Clear();
                                arr = true;
                                miss = true;
                            }
                        }
                    }
                }
            }while (!move);
            Console.ReadLine();
        }
    }
}