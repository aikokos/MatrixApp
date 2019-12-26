using System;
using System.Collections.Generic;
using System.Text;
using Matrix;

namespace MatrixConsoleApp
{
    class Summator<T>
    {
        public SquareMatrix<T> MakeMatrixSum(SquareMatrix<T> a, SquareMatrix<T> b)
        {
            T[,] elements = new T[a.elements.GetLength(0), a.elements.GetLength(1)];
            for (int i = 0; i < a.elements.GetLength(0); i++)
            {
                for (int j = 0; j < a.elements.GetLength(1); j++)
                {
                    Type listType = typeof(T);
                    if (listType == typeof(int))
                    {
                        elements[i, j] = (T)(object)(Convert.ToInt32(a.elements[i, j]) + Convert.ToInt32(b.elements[i, j]));
                    }
                }
            }
            SquareMatrix<T> sm = new SquareMatrix<T>(elements);
            return sm;
        }
    }
        
}
