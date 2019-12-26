using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    public class SymmetricMatrix<T> : SquareMatrix<T>
    {

        public SymmetricMatrix(T[,] el) : base(el)
        {

        }

        public void ChangeElementSymmetric(int i, int j, T element)
        {
            base.ChangeElement(i, j, element);
            if (i != j)
            {
                elements[j, i] = element;
            }
        }

    }
}
