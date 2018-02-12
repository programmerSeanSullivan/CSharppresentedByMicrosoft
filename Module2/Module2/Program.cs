using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    char firstChar = i % 2 == 0 ? 'X' : 'O';
                    char secondChar = i % 2 == 1 ? 'X' : 'O';
                    char output = j % 2 == 0 ? firstChar : secondChar;
                    Console.Write(output);
                }
                Console.Write('\n');
            }
        }
    }
}
