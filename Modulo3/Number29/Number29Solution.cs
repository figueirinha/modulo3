using System;

namespace Recodme.Training.Exercises.Number29
{
    public class Number29Solution
    {
        #region Exercise1
        public static int[] FirstExercise()
        {
            var arr = new int[10];
            var newArr = new int[12];
            var random = new Random();

            for (int i = 0; i < arr.Length; i++) arr[i] = random.Next(0, 11);            

            for (int i = 0; i < arr.Length; i++) newArr[i] = arr[i];          
                            
            return newArr;
        }
        #endregion

        #region Exercise2
        public static int[] SecondExercise()
        {
            var arr = new int[10];
            var newArr = new int[arr.Length];
            var random = new Random();
            var indexOf = 0;
            var count = 0;

            for (int i = 0; i < arr.Length; i++) arr[i] = random.Next(0, 11);           

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        newArr[indexOf] = count;
                    }
                }
                indexOf++;
                count = 0;
            }
            return newArr;
        }
        #endregion

        #region Exercise3
        public static int[] ThirdExercise()
        {
            var arr = new int[10];            
            var random = new Random();
            
            for (int i = 0; i < arr.Length; i++) arr[i] = random.Next(0, 11);        

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var help = arr[j];
                        arr[j] = arr[i];
                        arr[i] = help;
                    }
                }                
            }
            return arr;
        }
        #endregion

        #region Exercise4
        public static int[] FourthExercise()
        {
            var firstArr = new int[10];
            var secondArr = new int[5];
            var merge = new int[firstArr.Length + secondArr.Length];
            var random = new Random();

            for (int i = 0; i < firstArr.Length; i++) firstArr[i] = random.Next(0, 11);                           
            
            for (int i = 0; i < secondArr.Length; i++) secondArr[i] = random.Next(0, 11);

            for (int i = 0; i < firstArr.Length; i++) merge[i] = firstArr[i];

            for (int i = firstArr.Length; i < merge.Length; i++) merge[i] = secondArr[i - firstArr.Length];

            return merge;
        }
        #endregion

        #region Exercise5
        public static int FithExercise()
        {
            var arr = new int[10];            
            var random = new Random();
            var count = 0;

            for (int i = 0; i < arr.Length; i++) arr[i] = random.Next(-11, 11);
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Sign(arr[i]) == -1)
                {
                    count++;
                }
            }
                        
            return count;
        }
        #endregion

        #region Exercise6
        public static int[] SixthExercise()
        {
            var arr = new int[10];
            var uniqueArr = new int[arr.Length];
            var random = new Random();
            var count = 0;
            var indexOf = 0;

            for (int i = 0; i < arr.Length; i++) arr[i] = random.Next(0, 11);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) count++;
                }
                if (count == 1)
                {
                    uniqueArr[indexOf] = arr[i];
                    indexOf++;
                }
                count = 0;
            }

            var uniqueFinalArr = new int[indexOf];

            for (int i = 0; i < uniqueFinalArr.Length; i++) uniqueFinalArr[i] = uniqueArr[i];

            return uniqueFinalArr;
        }
        #endregion

        #region Exercise7a
        public static int[] SeventhAExercise()
        {
            var arr = new int[10];
            var resultArr = new int[arr.Length + 1];
            var random = new Random();
            var valueToAdd = random.Next(0, 11);

            for (int i = 0; i < arr.Length; i++) arr[i] = random.Next(0, 11);

            resultArr[0] = valueToAdd;

            for (int i = 1; i < resultArr.Length; i++) resultArr[i] = arr[i - 1];

            return resultArr;
        }
        #endregion

        #region Exercise7b
        public static int[] SeventhBExercise()
        {
            var arr = new int[10];
            var resultArr = new int[arr.Length + 1];
            var random = new Random();
            var valueToAdd = random.Next(0, 11);

            for (int i = 0; i < arr.Length; i++) arr[i] = random.Next(0, 11);

            resultArr[resultArr.Length - 1] = valueToAdd;

            for (int i = 0; i < resultArr.Length - 1; i++) resultArr[i] = arr[i];

            return resultArr;
        }
        #endregion

        #region Exercise7c
        public static int[] SeventhCExercise()
        {
            var arr = new int[10];
            var resultArr = new int[arr.Length + 1];
            var random = new Random();
            var valueToAdd = random.Next(0, 11);
            var toAddIndex = random.Next(0, resultArr.Length);

            for (int i = 0; i < arr.Length; i++) arr[i] = random.Next(0, 11);

            resultArr[toAddIndex] = valueToAdd;

            for (int i = 0; i < toAddIndex; i++) resultArr[i] = arr[i];

            for (int i = toAddIndex + 1; i < resultArr.Length; i++) resultArr[i] = arr[i - 1];

            return resultArr;
        }
        #endregion

        #region Exercise7d
        public static int[] SeventhDExercise()
        {
            var arr = new int[10];
            var resultArr = new int[arr.Length - 1];
            var random = new Random();            

            for (int i = 0; i < arr.Length; i++) arr[i] = random.Next(0, 11);

            for (int i = 0; i < resultArr.Length; i++) resultArr[i] = arr[i + 1];
                        
            return resultArr;
        }
        #endregion

        #region Exercise7e
        public static int[] SeventhEExercise()
        {
            var arr = new int[10];
            var resultArr = new int[arr.Length - 1];
            var random = new Random();

            for (int i = 0; i < arr.Length; i++) arr[i] = random.Next(0, 11);

            for (int i = 0; i < resultArr.Length; i++) resultArr[i] = arr[i];

            return resultArr;
        }
        #endregion
             
        #region Exercise7f
        public static int[] SeventhFExercise()
        {
            var arr = new int[10];
            var resultArr = new int[arr.Length - 1];
            var random = new Random();
            var toRemoveIndex = random.Next(0, arr.Length);

            for (int i = 0; i < arr.Length; i++) arr[i] = random.Next(0, 11);
                        
            for (int i = 0; i < toRemoveIndex; i++) resultArr[i] = arr[i];

            for (int i = toRemoveIndex; i < resultArr.Length; i++) resultArr[i] = arr[i + 1];

            return resultArr;
        }
        #endregion

        #region Exercise7g
        public static int SeventhGExercise(int[] arr, int element)
        {            
            var indexOfElement = 0;            
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element) indexOfElement = i; 
            } 
            
            return indexOfElement;
        }
        #endregion

        #region Exercise8
        public static void EighthExercise()
        {
            var arr = new int[10];
            var random = new Random();
            var toSplitIndex = random.Next(0, arr.Length);
            var arrOne = new int[toSplitIndex];
            var arrTwo = new int[arr.Length - toSplitIndex];

            for (int i = 0; i < arr.Length; i++) arr[i] = random.Next(0, 11);

            for (int i = 0; i < arrOne.Length; i++) arrOne[i] = arr[i];

            for (int i = 0; i < arrTwo.Length; i++) arrTwo[i] = arr[i + arrOne.Length];
                       
        }
        #endregion 
    }
}
