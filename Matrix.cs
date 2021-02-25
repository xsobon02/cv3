using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv3
{
    public class Matrix
    {
        private double[,] matx;

        public Matrix(double[,] matx)
        {
            this.matx = matx;
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            try
            {
                var mat1 = new Matrix(new double[a.matx.GetLength(0), a.matx.GetLength(1)]);
                for (int i = 0; i < a.matx.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matx.GetLength(1); j++)
                    {
                        mat1.matx[i, j] = a.matx[i, j] + b.matx[i, j];
                    }
                }
                return mat1;
            }
            catch
            {
                throw new Exception("Matrix dimensions aren't acceptable.");
            }

        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            try
            {
                var mat1 = new Matrix(new double[a.matx.GetLength(0), a.matx.GetLength(1)]);
                for (int i = 0; i < a.matx.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matx.GetLength(1); j++)
                    {
                        mat1.matx[i, j] = a.matx[i, j] - b.matx[i, j];
                    }
                }
                return mat1;
            }
            catch
            {
                throw new Exception("Matrix dimensions aren't acceptable.");
            }

        }
        public static Matrix operator *(Matrix a, Matrix b)
        {

            try
            {
                var mat1 = new Matrix(new double[a.matx.GetLength(0), b.matx.GetLength(1)]);
                for (int i = 0; i < a.matx.GetLength(0); i++)
                {
                    for (int j = 0; j < b.matx.GetLength(1); j++)
                    {
                        mat1.matx[i, j] = 0;
                        for (int k = 0; k < a.matx.GetLength(1); k++)
                        {
                            mat1.matx[i, j] += a.matx[i, k] * b.matx[k, j];
                        }
                    }
                }
                return mat1;
            }
            catch
            {
                throw new Exception("Matrix dimensions aren't acceptable.");
            }


        }
        public static bool operator ==(Matrix a, Matrix b)
        {
            return a.matx.Equals(b.matx);
        }
        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a.matx.Equals(b.matx));            
        }
        public static Matrix operator -(Matrix a)
        {
            var mat1 = new Matrix(new double[a.matx.GetLength(0), a.matx.GetLength(1)]);
            for (int i = 0; i < a.matx.GetLength(0); i++)
            {
                for (int j = 0; j < a.matx.GetLength(1); j++)
                {
                    mat1.matx[i, j] = a.matx[i, j] * (-1);
                }
            }
            return mat1;
        }
        public double Determinant()
        {
            try
            {
                if (matx.GetLength(0) == matx.GetLength(1) && matx.GetLength(1) == 1)
                {
                    return matx[0, 0];
                }
                else if (matx.GetLength(0) == matx.GetLength(1) && matx.GetLength(1) == 2)
                {
                    return matx[0, 0] * (matx[1, 1] - matx[0, 1] * matx[1, 0]);

                }
                else if (matx.GetLength(0) == matx.GetLength(1) && matx.GetLength(1) == 3)
                {
                    var determinant = matx[0, 0] * (matx[1, 1] * matx[2, 2] - matx[1, 2] * matx[2, 1]) -
                                      matx[0, 1] * (matx[1, 0] * matx[2, 2] - matx[1, 2] * matx[2, 0]) +
                                      matx[0, 2] * (matx[1, 0] * matx[2, 1] - matx[1, 1] * matx[2, 0]);

                    return determinant;
                }
            }
            catch
            {
                throw new Exception("Matrix dimensions aren't acceptable.");
            }
            return 0;
        }
        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < matx.GetLength(0); i++)
            {
                for (int j = 0; j < matx.GetLength(1); j++)
                {
                    if (j != matx.GetLength(0) - 1) output += $"{matx[i, j]},";
                }
                output += "\n";
            }

            return output;
        }
    }
}
