using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial
{
    class BattleField
    {
        public string[][] Field { get; set; }

        public void DisplayBattleField()
        {
            for (int i = 0; i < Field.Length; i++)
            {
                for (int j = 0; j < Field[i].Length; j++)
                {
                    if (Field[i][j].Contains("0"))
                        Console.ForegroundColor = ConsoleColor.White;
                    else if (Field[i][j].Contains("+"))
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write(Field[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
