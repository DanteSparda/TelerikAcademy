namespace Defining_Classes___Part_2.GenericClasses
{
    using System;
    using System.Collections.Generic;

    public class Matrix<T>
    {
        private T[,] matrixArray;
        private int rowCap;
        private int colCap;
        private int reachedRow = 0;
        private int reachedCol = 0;

        public Matrix(int rowLength, int colLength)
        {
            this.matrixArray = new T[rowLength, colLength];
            this.rowCap = rowLength;
            this.colCap = colLength;
        }

        public T this[int row, int col]
        {
            get { return this.matrixArray[row, col]; }
            set { this.matrixArray[row, col] = value; }
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.rowCap != matrix2.rowCap || matrix1.colCap != matrix2.colCap)
            {
                throw new ArgumentException("Matrices' size not equal");
            }

            var newMatrix = new Matrix<T>(matrix2.rowCap, matrix1.colCap);

            for (int row = 0; row < matrix1.rowCap; row++)
            {
                for (int col = 0; col < matrix2.colCap; col++)
                {
                    // Sorry, can't figure out any other way... and yes dynamic is BAD!
                    newMatrix[row, col] = (dynamic)matrix1[row, col] + matrix2[row, col];
                }
            }

            return newMatrix;
        }

        public static bool operator true(Matrix<T> input)
        {
            bool result = false;
            for (int row = 0; row < input.rowCap; row++)
            {
                for (int col = 0; col < input.colCap; col++)
                {
                    if (input[row, col].ToString() != "0")
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        public static bool operator false(Matrix<T> input)
        {
            bool result = false;
            for (int row = 0; row < input.rowCap; row++)
            {
                for (int col = 0; col < input.colCap; col++)
                {
                    if (input[row, col].ToString() == "0")
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.rowCap != matrix2.rowCap || matrix1.colCap != matrix2.colCap)
            {
                throw new ArgumentException("Matrices' size not equal");
            }

            var newMatrix = new Matrix<T>(matrix2.rowCap, matrix1.colCap);

            for (int row = 0; row < matrix1.rowCap; row++)
            {
                for (int col = 0; col < matrix2.colCap; col++)
                {
                    // Sorry, can't figure out any other way... and yes dynamic is BAD!
                    newMatrix[row, col] = (dynamic)matrix1[row, col] - matrix2[row, col];
                }
            }

            return newMatrix;
        }

        public void Add(T element)
        {
            if (this.reachedCol == this.colCap)
            {
                if (this.reachedRow == this.rowCap)
                {
                    throw new ArgumentException("Out of memory!");
                }

                this.reachedRow++;
                this.reachedCol = 0;
                this.matrixArray[this.reachedRow, this.reachedCol] = element;
                this.reachedCol++;
            }
            else
            {
                this.matrixArray[this.reachedRow, this.reachedCol] = element;
                this.reachedCol++;
                if (this.reachedCol == this.colCap + 1)
                {
                    this.reachedRow++;
                    if (this.reachedRow == this.rowCap + 1)
                    {
                        throw new ArgumentException("The array is now full!");
                    }
                }
            }
        }
    }
}
