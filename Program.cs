using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat1 = new double[,] 
            {
                { 1, 2, 3 },
                { 3, 4, 5 },
                { 3, 7, 8 }


            };
            double[,] mat2 = new double[,] 
            {
                { 5, 4, 2 },
                { 3, 4, 2 },
                { 1, 3, 6 }
            };

            Matrix m1 = new Matrix(mat1);
            Matrix m2 = new Matrix(mat2);

            Console.WriteLine("Addition:");
            Console.WriteLine(m1 + m2);
            Console.WriteLine("Subtraction:");
            Console.WriteLine(m1 - m2);
            Console.WriteLine("Multiplication:");
            Console.WriteLine(m1 * m2);
            Console.WriteLine("Equal:");
            Console.WriteLine(m1 == m2);
            Console.WriteLine("");
            Console.WriteLine("Nonequal:");
            Console.WriteLine(m1 != m2);
            Console.WriteLine("");
            Console.WriteLine("Determinant:");
            Console.WriteLine(m1.Determinant());
            Console.ReadLine();
        }
    }
}
