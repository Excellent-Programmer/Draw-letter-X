using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letter_X
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, column;

 
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && (row > 4 || row < 2)) || row == column && column > 0 && column < 6 || (column == 2 && row == 4) || (column == 4 && row == 2))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Read();
        }
    }
}
