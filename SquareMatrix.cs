using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    public class SquareMatrix<T>
    {

        public T[,] elements;

        public SquareMatrix(T[,] el)
        {
            elements = new T[el.GetLength(0), el.GetLength(1)];
            for (int i = 0; i < el.GetLength(0); i++)
            {
                for (int j = 0; j < el.GetLength(1); j++)
               {
                    elements[i,j] = el[i,j];
                }
            }
        }

        public void ChangeElement(int i, int j, T element)
        {
            elements[i, j] = element;
        }

        public void ShowElements()
        {
            for (int i = 0; i < elements.GetLength(0); i++)
            {
                for (int j = 0; j < elements.GetLength(1); j++)
                {
                    Console.Write(elements[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
