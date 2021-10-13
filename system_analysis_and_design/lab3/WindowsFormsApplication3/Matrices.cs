using System;
using System.Collections.Generic;
using System.Text;

namespace ImageTransformationsApp
{
    class Matrices
    {
        public static double[,] CreateIdentityMatrix(int length)
        {
            double[,] matrix = new double[length, length];

            for (int i = 0, j = 0; i < length; i++, j++)
                matrix[i, j] = 1;

            return matrix;
        }
        public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
        {
            var matrix1Rows = matrix1.GetLength(0);
            var matrix1Cols = matrix1.GetLength(1);
            var matrix2Rows = matrix2.GetLength(0);
            var matrix2Cols = matrix2.GetLength(1);

            if (matrix1Cols != matrix2Rows)
                throw new InvalidOperationException
                  ("User error");

            double[,] product = new double[matrix1Rows, matrix2Cols];

            for (int matrix1_row = 0; matrix1_row < matrix1Rows; matrix1_row++) {

                for (int matrix2_col = 0; matrix2_col < matrix2Cols; matrix2_col++) {

                    for (int matrix1_col = 0; matrix1_col < matrix1Cols; matrix1_col++) {
                        product[matrix1_row, matrix2_col] +=
                          matrix1[matrix1_row, matrix1_col] *
                          matrix2[matrix1_col, matrix2_col];
                    }
                }
            }

            return product;
        }
    }
}
