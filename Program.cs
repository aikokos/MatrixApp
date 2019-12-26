using Matrix;
using System;

namespace MatrixConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] myArr = {
                        {1,10},
                        {2,20}
                      };
            int[,] myArr1 = {
                        {1,10},
                        {2,20}
                      };

            SquareMatrix<int> sm = new SquareMatrix<int>(myArr);
            SquareMatrix<int> sm1 = new SquareMatrix<int>(myArr1);

            sm.ShowElements();

            //sm.ChangeElement(0, 0, 30);

            sm.ShowElements();

            Summator<int> summator = new Summator<int>();
            SquareMatrix<int> sm3 =  summator.MakeMatrixSum(sm, sm1);
            Console.WriteLine("sm3 elements");
            sm3.ShowElements();
            SymmetricMatrix<int> sm4 = new SymmetricMatrix<int>(myArr);
            SymmetricMatrix<int> sm5 = new SymmetricMatrix<int>(myArr1);
            sm4.ShowElements();
            sm5.ShowElements();
            SquareMatrix<int> sm6 = summator.MakeMatrixSum(sm4, sm5);
            Console.WriteLine("sm6 elements");
            sm6.ShowElements();
        }
    }
}
