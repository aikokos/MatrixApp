using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    public class DiagonalMatrix<T> : SymmetricMatrix<T>
    {
        T defElement;

        public DiagonalMatrix(T[,] el, T defEl) : base(el)
        {
            defElement = defEl;
        }

        public void ChangeElementDiagonal(int i, int j, T element)
        {
            if (i == j)
            {
                base.ChangeElement(i, j, element);
            }
            else
            {
                elements[i, j] = defElement;
            }
        }

    }
}
