using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMath
{
    public class Matrix<T>
    {
        public Matrix(int i, int j)
        {
            matrix = new T[i, j];
        }
        public Matrix(T[,] temp)
        {
            matrix = temp;

            int i = 0;
            try
            {
                while (true)
                {
                    matrix[0, i] = matrix[0, i];
                    i++;
                }
            }
            catch (Exception e) { col = i; }

            i = 0;
            try
            {
                while (true)
                {
                    matrix[i, 0] = matrix[i, 0];
                    i++;
                }
            }
            catch (Exception e) { row = i; }
        }

        public T this[int i, int j]
        {
            get
            {
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }
        public int Col
        {
            get { return col; }
            set { col = value; }
        }
        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        private T[,] matrix;
        private int row;
        private int col;

        public Matrix<T> Transposition()
        {
            Matrix<T> result = new Matrix<T>(this.col, this.row);
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.col; j++)
                {
                    result.matrix[j, i] = this.matrix[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator +(Matrix<T> obj1, Matrix<T> obj2)
        {
            if (obj1.row == obj2.row && obj1.col == obj2.col)
            {
                Matrix<T> arr = new Matrix<T>(obj1.row, obj1.col);
                for (int i = 0; i < obj1.row; i++)
                {
                    for (int j = 0; j < obj1.col; j++)
                    {
                        arr.matrix[i, j] = (dynamic)obj1.matrix[i, j] + (dynamic)obj2.matrix[i, j];
                    }
                }
                return arr;
            }
            else
            {
                Convert.ToInt32(" ");
                return new Matrix<T>(0, 0);
            }
        }
        public static Matrix<T> operator -(Matrix<T> obj1, Matrix<T> obj2)
        {
            if (obj1.row == obj2.row && obj1.col == obj2.col)
            {
                Matrix<T> arr = new Matrix<T>(obj1.row, obj1.col);
                for (int i = 0; i < obj1.row; i++)
                {
                    for (int j = 0; j < obj1.col; j++)
                    {
                        arr.matrix[i, j] = (dynamic)obj1.matrix[i, j] - (dynamic)obj2.matrix[i, j];
                    }
                }
                return arr;
            }
            else
            {
                Convert.ToInt32(" ");
                return new Matrix<T>(0, 0);
            }
        }
        public static Matrix<T> operator *(Matrix<T> obj1, Matrix<T> obj2)
        {
            if (obj2.row == obj1.col)
            {
                Matrix<T> arr = new Matrix<T>(obj1.row, obj2.col);
                for (int i = 0; i < obj1.row; i++)
                {
                    for (int j = 0; j < obj2.col; j++)
                    {
                        for (int k = 0; k < obj1.col; k++)
                        {
                            arr.matrix[i, j] += (dynamic)obj1.matrix[i, k] * (dynamic)obj2.matrix[k, j];
                        }
                    }
                }
                return arr;
            }
            else
            {
                Convert.ToInt32(" ");
                return new Matrix<T>(0, 0);
            }
        }
    }
}
