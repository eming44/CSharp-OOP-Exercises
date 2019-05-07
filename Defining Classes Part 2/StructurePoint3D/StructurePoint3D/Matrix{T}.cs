using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructurePoint3D
{
    class Matrix<T>
       // where T : int
    {
        private int rows;
        private int cols;
        private T[,] elements;
        private int count;

        public int RowsGet
        {
            get
            {
                return this.rows;
            }
        }

        public int ColsGet
        {
            get
            {
                return this.cols;
            }
        }

        public int CountGet
        {
            get
            {
                return this.count;
            }
        }

        public Matrix(int newRows, int newCols)
        {
            this.rows = newRows;
            this.cols = newCols;
            this.elements = new T[this.rows, this.cols];
            this.count = this.rows * this.cols;
        }
        public T this[int row, int col]
        {
            get
            {
                return this.elements[row, col];
            }
            set
            {
                this.elements[row, col] = value;
            }
        }

        public static Matrix<T> operator+ (Matrix<T> first, Matrix<T> second)
        {
            if (first.sameSize(second))
            {
                Matrix<T> newMatrix = new Matrix<T>(first.RowsGet, first.ColsGet);
                for (int r = 0; r < first.RowsGet; r++)
                {
                    for (int c = 0; c < first.ColsGet; c++)
                    {
                        dynamic firstMatrix = first[r, c];
                        dynamic secondMatrix = second[r, c];
                        newMatrix[r, c] = firstMatrix + secondMatrix;
                    }
                }
                return newMatrix;
            }
            else
            {
                throw new ArithmeticException();
            }
        }

        public static Matrix<T> operator- (Matrix<T> first, Matrix<T> second)
        {
            if (first.sameSize(second))
            {
                Matrix<T> newMatrix = new Matrix<T>(first.RowsGet, first.cols);
                for (int r = 0; r < first.RowsGet; r++)
                {
                    for (int c = 0; c < first.ColsGet; c++)
                    {
                        dynamic firstMatrix = first[r, c];
                        dynamic secondMatrix = second[r, c];
                        newMatrix[r, c] = firstMatrix - secondMatrix;

                    }
                }
                return newMatrix;
            }
            else
            {
                throw new ArithmeticException();
            }
        }

        public static Matrix<T> operator* (Matrix<T> first, Matrix<T> second)
        {
            if (first.ColsGet == second.RowsGet)
            {
                Matrix<T> newMatrix = new Matrix<T>(first.RowsGet, second.ColsGet);

                for (int r = 0; r < first.RowsGet; r++)
                {
                    int colsMultiply = 0;
                    dynamic sum = 0;
                    int cols = 0;
                    for (int c = 0; c < second.RowsGet; c++)
                    {
                        dynamic firstMatrix = first[r, c];
                        dynamic secondMatrix = second[c, colsMultiply];
                        sum += (firstMatrix * secondMatrix);
                        if (c == second.RowsGet - 1 && colsMultiply < second.ColsGet)
                        {
                            c = -1;
                            colsMultiply++;
                            newMatrix[r, cols] = sum;
                            cols++;
                            sum = 0;
                            if (colsMultiply == second.ColsGet)
                            {
                                break;
                            }
                        }
                    }
                }
                return newMatrix;
            }
            else
            {
                throw new ArithmeticException();
            }
        }

        public static Matrix<T> operator* (Matrix<T> matrix, int num)
        {
            Matrix<T> newMatrix = new Matrix<T>(matrix.RowsGet, matrix.ColsGet);

            for (int r = 0; r < matrix.RowsGet; r++)
            {
                for (int c = 0; c < matrix.ColsGet; c++)
                {
                    dynamic matrixValue = matrix[r, c];
                    newMatrix[r, c] = num * matrixValue; 
                }
            }

            return newMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int r = 0; r < matrix.RowsGet; r++)
            {
                for (int c = 0; c < matrix.ColsGet; c++)
                {
                    dynamic a = matrix[r, c];
                    if (a == 0) return true;
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int r = 0; r < matrix.RowsGet; r++)
            {
                for (int c = 0; c < matrix.ColsGet; c++)
                {
                    dynamic a = matrix[r, c];
                    if (a == 0) return false;
                }
            }
            return true;
        }

        private bool sameSize(Matrix<T> matrix)
        {
            bool same = false;

            if((this.RowsGet == matrix.RowsGet) && (this.ColsGet == matrix.ColsGet))
            {
                same = true;
            }

            return same;
        }
    }
}
