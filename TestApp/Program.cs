using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMath;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> matrix = new Matrix<int>(2, 3);
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            Console.Write(matrix.Transposition().ToString());
            Equation a = new Equation(3, -2, 1);
            Console.Write(a.X);
            Console.Read();
        }
    }
}
