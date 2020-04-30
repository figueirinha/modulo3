using System;

namespace Recodme.Training.Exercises.Number30
{
    public class Number30Solution
    {
        #region Exercise1a
        public static void FirstAExercise()
        {
            int[][] matrix = new int[2][];
            matrix[0] = new int[2];
            matrix[1] = new int[2];

            var random = new Random();
            var line = random.Next(0, 2);
            var row = random.Next(0, 2);

            matrix[line][row] = random.Next(0, 11);           
        }
        #endregion

        #region Exercise1b
        public static void FirstBExercise()
        {
            int[][] matrix = new int[2][];
            matrix[0] = new int[2];
            matrix[1] = new int[2];

            var random = new Random();
            var line = random.Next(0, 2);
            var row = random.Next(0, 2);

            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix[1].Length; j++) matrix[i][j] = random.Next(0, 11);
            }

            matrix[line][row] = default;
        }
        #endregion

        #region Exercise1c
        public static void FirstCExercise()
        {
            int[][] matrix = new int[2][];
            matrix[0] = new int[2];
            matrix[1] = new int[2];

            var random = new Random();
            var line = random.Next(0, 2);
            var row = random.Next(0, 2);
            

            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix[1].Length; j++) matrix[i][j] = random.Next(0, 11);
            }

            var theElementWanted = matrix[line][row];
        }
        #endregion 

        #region Exercise1d
        public static void FirstDExercise()
        {
            int[][] matrix = new int[2][];
            matrix[0] = new int[2];
            matrix[1] = new int[2];

            var random = new Random();
            
            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix[1].Length; j++) matrix[i][j] = random.Next(0, 11);
            }

            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix[1].Length; j++) Console.Write(matrix[i][j] + " ");
                Console.WriteLine();
            }
        }
        #endregion
               
        #region Exercise2a
        public static void SecondAExercise()
        {
            int[][][] matrix = new int[3][][];
            matrix[0] = new int[3][];
            matrix[0][0] = new int[3];
            matrix[0][1] = new int[3];
            matrix[0][2] = new int[3];

            matrix[1] = new int[3][];
            matrix[1][0] = new int[3];
            matrix[1][1] = new int[3];
            matrix[1][2] = new int[3];

            matrix[2] = new int[3][];
            matrix[2][0] = new int[3];
            matrix[2][1] = new int[3];
            matrix[2][2] = new int[3];

            var random = new Random();
            var line = random.Next(0, 3);
            var row = random.Next(0, 3);
            var dir = random.Next(0, 3);

            matrix[line][row][dir] = random.Next(0, 11);
        }
        #endregion
        
        #region Exercise2b
        public static void SecondBExercise()
        {
            int[][][] matrix = new int[3][][];
            matrix[0] = new int[3][];
            matrix[0][0] = new int[3];
            matrix[0][1] = new int[3];
            matrix[0][2] = new int[3];

            matrix[1] = new int[3][];
            matrix[1][0] = new int[3];
            matrix[1][1] = new int[3];
            matrix[1][2] = new int[3];

            matrix[2] = new int[3][];
            matrix[2][0] = new int[3];
            matrix[2][1] = new int[3];
            matrix[2][2] = new int[3];

            var random = new Random();
            var line = random.Next(0, 3);
            var row = random.Next(0, 3);
            var dir = random.Next(0, 3);


            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix[1].Length; j++) 
                {
                    for (int k = 0; k < matrix[2].Length; k++) matrix[i][j][k] = random.Next(0, 11);
                } 
            }

            matrix[line][row][dir] = default;
        }
        #endregion

        #region Exercise2c
        public static void SecondCExercise()
        {
            int[][][] matrix = new int[3][][];
            matrix[0] = new int[3][];
            matrix[0][0] = new int[3];
            matrix[0][1] = new int[3];
            matrix[0][2] = new int[3];

            matrix[1] = new int[3][];
            matrix[1][0] = new int[3];
            matrix[1][1] = new int[3];
            matrix[1][2] = new int[3];

            matrix[2] = new int[3][];
            matrix[2][0] = new int[3];
            matrix[2][1] = new int[3];
            matrix[2][2] = new int[3];

            var random = new Random();
            var line = random.Next(0, 3);
            var row = random.Next(0, 3);            
            var dir = random.Next(0, 3);


            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix[1].Length; j++)
                {
                    for (int k = 0; k < matrix[2].Length; k++) matrix[i][j][k] = random.Next(0, 11);
                }
            }

            var theElementWanted = matrix[line][row][dir];
        }
        #endregion

        #region Exercise4
        public static void FourthExercise()
        {
            int[][] matrixOne = new int[2][];
            matrixOne[0] = new int[2];
            matrixOne[1] = new int[2];

            int[][] matrixTwo = new int[2][];
            matrixTwo[0] = new int[2];
            matrixTwo[1] = new int[2];

            int[][] resultMatrix = new int[2][];
            resultMatrix[0] = new int[2];
            resultMatrix[1] = new int[2];

            var random = new Random();
          
            for (int i = 0; i < matrixOne[0].Length; i++)
            {
                for (int j = 0; j < matrixOne[1].Length; j++) matrixOne[i][j] = random.Next(0, 11);
            }

            for (int i = 0; i < matrixTwo[0].Length; i++)
            {
                for (int j = 0; j < matrixTwo[1].Length; j++) matrixTwo[i][j] = random.Next(0, 11);
            }

            for (int i = 0; i < resultMatrix[0].Length; i++)
            {
                for (int j = 0; j < resultMatrix[1].Length; j++) resultMatrix[i][j] = matrixOne[i][j] + matrixTwo[i][j];
            }
        }
        #endregion

        #region Exercise5
        public static void FifthExercise()
        {
            int[][] matrixOne = new int[2][];
            matrixOne[0] = new int[2];
            matrixOne[1] = new int[2];

            int[][] matrixTwo = new int[2][];
            matrixTwo[0] = new int[2];
            matrixTwo[1] = new int[2];

            int[][] resultMatrix = new int[2][];
            resultMatrix[0] = new int[2];
            resultMatrix[1] = new int[2];

            var random = new Random();
         
            for (int i = 0; i < matrixOne[0].Length; i++)
            {
                for (int j = 0; j < matrixOne[1].Length; j++) matrixOne[i][j] = random.Next(0, 11);
            }

            for (int i = 0; i < matrixTwo[0].Length; i++)
            {
                for (int j = 0; j < matrixTwo[1].Length; j++) matrixTwo[i][j] = random.Next(0, 11);
            }

            for (int i = 0; i < resultMatrix[0].Length; i++)
            {
                for (int j = 0; j < resultMatrix[1].Length; j++) resultMatrix[i][j] = matrixOne[i][j] - matrixTwo[i][j];
            }
        }
        #endregion

        #region Exercise6
        public static void SixthExercise()
        {
            int[][] matrix = new int[2][];
            matrix[0] = new int[2];
            matrix[1] = new int[2];

            int[][] resultMatrix = new int[2][];
            resultMatrix[0] = new int[2];
            resultMatrix[1] = new int[2];

            var random = new Random();
            var numToMultiply = random.Next(0, 11);

            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix[1].Length; j++) matrix[i][j] = random.Next(0, 11);
            }
            
            for (int i = 0; i < resultMatrix[0].Length; i++)
            {
                for (int j = 0; j < resultMatrix[1].Length; j++) resultMatrix[i][j] = matrix[i][j] * numToMultiply;
            }
        }
        #endregion

        #region Exercise7
        public static void SeventhExercise()
        {
            int[][] matrix = new int[2][];
            matrix[0] = new int[2];
            matrix[1] = new int[2];

            var random = new Random();
            var minimumZeros = matrix[0].Length * (matrix[0].Length - 1) / 2; //For n x n
            var countZeros = 0;
            var isTriangular = false;

            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix[1].Length; j++) matrix[i][j] = random.Next(0, 2);
            }

            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix[1].Length; j++)
                {
                    if (i < j)
                    {
                        if (matrix[i][j] == 0)
                        {
                            countZeros++;
                        }
                    }
                }
            }

            if (countZeros == minimumZeros && countZeros != 0)
            {
                Console.WriteLine("It's a triangular UPPER matrix");
                isTriangular = true;
            }

            countZeros = 0; 

            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < matrix[1].Length; j++)
                {
                    if (i > j)
                    {
                        if (matrix[i][j] == 0)
                        {
                            countZeros++;
                        }
                    }
                }
            }

            if (countZeros == minimumZeros && countZeros != 0)
            {
                Console.WriteLine("It's a triangular LOWER matrix");
                isTriangular = true;
            }

            if (!isTriangular) Console.WriteLine("This matrix ain't triangular (upper or lower) at all.");
        }
        #endregion 

        #region Exercise8
        public static void EighthExercise()
        {

        }
        #endregion 

        #region Exercise9
        public static void NinthExercise()
        {

        }
        #endregion 

        #region Exercise10
        public static void TenthExercise()
        {

        }
        #endregion 

        #region Exercise11
        public static void EleventhExercise()
        {

        }
        #endregion 

        #region Exercise12
        public static void TwelfthExercise()
        {

        }
        #endregion 
    }
}
