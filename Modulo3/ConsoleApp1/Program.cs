using ClassExample;
using QueueExample;
using Recodme.Training.Exercises.Number29;
using Recodme.Training.Exercises.Number30;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //add a breakpoint on the class to see results from Number29 to Number32. All arrays where made using Random()   

            //Work sheet number 29
            /*
            Number29Solution.FirstExercise();
            Number29Solution.SecondExercise();
            Number29Solution.ThirdExercise();
            Number29Solution.FourthExercise();
            Number29Solution.FithExercise();
            Number29Solution.SixthExercise();
            Number29Solution.SeventhAExercise();
            Number29Solution.SeventhBExercise();
            Number29Solution.SeventhCExercise();
            Number29Solution.SeventhDExercise();
            Number29Solution.SeventhEExercise();
            Number29Solution.SeventhFExercise();
            var arr = new int[5] { 1, 2, 3, 4, 5 };
            Number29Solution.SeventhGExercise(arr, 2);
            Number29Solution.EighthExercise();
            */

            //Work sheet number 30
            /*
            Number30Solution.FirstAExercise();
            Number30Solution.FirstBExercise();
            Number30Solution.FirstCExercise();
            Number30Solution.FirstDExercise();
            Number30Solution.SecondAExercise();
            Number30Solution.SecondBExercise();
            Number30Solution.SecondCExercise();
            Number30Solution.FourthExercise();
            Number30Solution.FifthExercise();
            Number30Solution.SixthExercise();
            Number30Solution.SeventhExercise();
            Number30Solution.EighthExercise();
            Number30Solution.NinthExercise();
            Number30Solution.TenthExercise(); //NOT DONE!!!!!!!!!! (Matrices determinants)
            Number30Solution.EleventhExercise(); //Only Done for 2 matrices with same dimensions (n x n)
            Number30Solution.TwelfthExercise(); //Only for (n x n)
            */



            //Stack Example
            /*
            var products = new Stack<Product>();

            var prod1 = new Product("cola", 11111111, 1.20, TypeOfProduct.Sodas);
            var prod2 = new Product("skitles", 22222222, 1.20, TypeOfProduct.Sweet);
            var prod3 = new Product("water", 33333333, 1.20, TypeOfProduct.Water);

            products.Push(prod1);
            products.Push(prod2);
            products.Push(prod3);
            var last = products.Pop();
            */

            //Queue Example
            /*
            var client = new Queue<Facturation>();

            var fact1 = new Facturation("Miguel", 1111111, 60, "ACNH");
            var fact2 = new Facturation("Ze", 22222, 300, "Tablet");
            var fact3 = new Facturation("Zeze", 333333, 900, "PC");

            client.Enqueue(fact1);
            client.Enqueue(fact2);
            client.Enqueue(fact3);
            var remove = client.Dequeue();
            */
        }
    }
}
