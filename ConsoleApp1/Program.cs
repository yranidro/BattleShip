using System;
namespace Name
{
    class ClassName
    {
        static void Main(string[] args)
        {
            int[,] enemyGameZone = new int[10, 10];
            bool theEnd;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (enemyGameZone[i, j] == 1)
                        {
                            theEnd = false;
                            continue;
                        }
                        else if (enemyGameZone[i, j] == 0 || enemyGameZone[i, j] == 2)
                            theEnd = true;
                    }
                }
        }
    }
}