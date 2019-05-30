using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    internal static class Program
    {
//        private static ManualResetEvent _event;
//
//        static void
//            Main(string[] args)
//        {
//            _event = new ManualResetEvent(true);
//            new Thread(Thread0).Start();
//            while (true)
//            {    
//                Console.ReadKey();
//                _event.Set();
//
////                _event.Reset();
//            }
//        }
//
//        static void Thread0()
//        {
//            var i = 0;
//            while(true)
//            {
//                i++;
//                _event.WaitOne();
//                Console.WriteLine("hello "+i);
//                _event.Reset();
//
////                Console.WriteLine("Thread0: " + i);
////                // Какое-то условие, при выполнении которого
////                // второй поток будет приостанавливаться
////                if (i % 10 == 0)
////                {
////                    _event.Reset(); // Приостановка Thread1...
////                    {
////                        // Здесь код, который будет выполнятся
////                        // когда Thread1 приостановлен
////                        // Thread.Sleep для эмуляции работы
////                        Thread.Sleep(1000);
////                    }
////                    _event.Set(); // Продолжение выполнения Thread1...
////                }
//            }
//        }

//
//        static void Thread1()
//        {
//            for (int i = 0; i < 1000; ++i)
//            {
//                _event.WaitOne();
//                // Какая-то работа...
//                Console.WriteLine("\tThread1: " + i);
//            }
//        }
        public static void Main(string[] args)
        {
//            double[][] matrix = new double[][] {
//                new double[] { 5,  7,  6 },
//                new double[] { 3,  16, 19 },
//                new double[] { 13, 10, 7 }
//            };
//            var matrix = new[]
//            {
//                new double[] {-2, 1, 3, 2},
//                new double[] {3, 0, -1, 2},
//                new double[] {-5, 2, 3, 0},
//                new double[] {4, -1, 2, -3}
//            };
//            var matrix = new[]
//            {
//                new double[] {0, 0, 0, 0},
//                new double[] {0, 0, 0, 0},
//                new double[] {0, 0, 0, 0},
//                new double[] {0, 0, 0, 0}
//            };
//            double[][] matrix = new double[][] {
//                new double[] { 11,  -2 },
//                new double[] { 7, 5}
//            };
            double[][] matrix = new double[][] {
                new double[] { 1, 2, 3 },
                new double[] { 4, 5, 6 },
                new double[] { 7, 8, 9 }
            };

            Console.Write(MatrixToStr(matrix));
            MessageBox.Show(MatrixToStr(matrix));
            Console.WriteLine("*");

            var size = matrix.Length;

            var counter = 1;
            for (var str = 0; str < matrix.Length; str++)
            {
                for (var j = str + 1; j < size; j++)
                {
                    var mul = -(matrix[j][str] / matrix[str][str]);
                    var mul2 = MultiplyMas(matrix[str], mul);
                    var newStr = FoldMasvs(matrix[j], mul2);
                    matrix[j] = newStr;
                    PrintMatrix(matrix);
                    Console.WriteLine($"step: {counter++}");
                    Console.ReadKey();
                }

            }

            PrintMatrix(matrix);

            double determinant = 1;
            for (int i = 0, j = 0; i < matrix.Length; i++, j++)
            {
                determinant *= matrix[i][j];
            }

            Console.WriteLine($"Determinant: {determinant}");

            Console.ReadKey();
        }

        private static double[] FoldMasvs(double[] mas1, double[] mas2)
        {
            var newMas = new double[mas1.Length];
            Array.Copy(mas1, newMas, mas1.Length);
            for (var i = 0; i < mas2.Length; i++)
                newMas[i] += mas2[i];
            return newMas;
        }

        private static double[] MultiplyMas(double[] mas, double value)
        {
            var newMas = new double[mas.Length];
            Array.Copy(mas, newMas, mas.Length);
            for (var i = 0; i < mas.Length; i++)
            {
                newMas[i] *= value;
            }

            return newMas;
        }

        private static string MatrixToStr(double[][] matrix)
        {
            var result = "";

            foreach (var str in matrix)
            {
                Array.ForEach(str, i => result+=i + " ");
                result+="\n";
            }

            return result;
        }
        private static void PrintMatrix(double[][] matrix)
        {
            Console.WriteLine(new string('=', matrix.First().Length * matrix.Max(x => x.Length)));

            foreach (var str in matrix)
            {
                Array.ForEach(str, i => Console.Write(i + " "));
                Console.WriteLine();
            }

            Console.WriteLine(new string('=', matrix.First().Length * matrix.Max(x => x.Length)));
        }
    }
}