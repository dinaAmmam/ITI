using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp81
{
    class Program
    {
        //task1
        //fill array
        public static void FillArray(int[] arr)
        {
            Console.WriteLine("fill array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}]=");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        //display array 
        public static void DisplayArray(int[] arr)
        {
            Console.WriteLine("displaying values");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        }
        //sumArray
        public static int SumArray(int[] arr)
        {
            Console.WriteLine("sum array");
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            return sum;
        }
        //get odd
        public static int[] GettOdd(int[] arr)
        {
            Console.WriteLine("odd numbers");
            int[] odd = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    odd[i] = arr[i];
                }
            }
            return odd;
        }
        //get even
        public static int[] GetEven(int[] arr)
        {
            Console.WriteLine("even numbers");
            int[] even = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[i] = arr[i];
                }
            }
            return even;

        }
        //get max
        public static int GetMax(int[] arr)
        {
            Console.WriteLine("get max");
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        //get min
        public static int GetMin(int[] arr)
        {
            Console.WriteLine("get min");
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        //get avg
        public static int GetAvg(int[] arr)
        {
            Console.WriteLine("get avg");
            int Sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Sum += arr[i];
            }
            int avg = Sum / arr.Length;
            return avg;
        }
        //task 2
        //fill
        public static void FillTwoDimArray(int[,] arr)
        {
            Console.WriteLine("fill two dim array");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"row {i + 1} data");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"column{j + 1} = {arr[i, j]}");
                    arr[i, j] = int.Parse(Console.ReadLine());

                }
            }
        }
        //display
        public static void DisplayArray2(int[,] arr)
        {
            Console.WriteLine("displaying values");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"arr[row{i} , column{j}] = {arr[i, j]}");
                }

            }
        }
        //get row sum
        public static void GetRowSum(int[,] arr)
        {
            Console.WriteLine("get row sum");
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"sum for row{i + 1} ");
                sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];

                }
                Console.WriteLine(sum);

            }
            // return sum;
        }
        //col avg
        public static void GetColAvg(int[,] arr)
        {
            Console.WriteLine("get col avg");
            int avg;
            int colTotal;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                colTotal = 0;
                int j = 0;
                for (; j < arr.GetLength(1); j++)
                {
                    colTotal += arr[j, i];

                }
                avg = colTotal / arr.GetLength(1);
                Console.WriteLine(avg);
            }
        }

        //concat
        public static int[] concat(int[] arr1, int[] arr2)
        {
            Console.WriteLine("concate");
            int newsize = arr1.Length + arr2.Length;
            int[] newarr = new int[newsize];
            for (int i = 0; i < arr1.Length; i++)
            {
                newarr[i] = arr1[i];
            }
            int l = arr1.Length;
            for (int i = 0; i < arr2.Length; i++)
            {
                newarr[l] = arr2[i];
                l += 1;
            }
            // another sol
            //int [] concatarr = arr1.Concat(arr2).ToArray(); 
            //Console.WriteLine(concatarr);
            return newarr;
        }
        public static void repeat()
        {

            int[] array = { 10, 50, 10, 2, 2, 3, 4, 50, 50, 6, 7, 8, 5, 11, 10, 12 };
            int count = 1;
            for (int i = 0; i<array.Length; i++)
            {
            for (int j = i; j<array.Length - 1 ; j++)
            {

               if(array[j] == array[j + 1])
                    {count = count + 1;}
            }
                Console.WriteLine("\t\n " + array[i] + "occurse" + count);
            }

        }


            //check
            public static void checkUnique(int [] arr)
        {
            Console.WriteLine("please first value");
            arr[0] = int.Parse(Console.ReadLine());
            for (int i =1; i<10; i++)
            {
                    Console.WriteLine("please array values");
                    int _newV = int.Parse(Console.ReadLine()); //put into var before put in array then do while 
                    if(arr[i-1] != arr[i-1] ) // طول ما هو متساوي ادخل رقم تاني
                    {
                        Console.WriteLine($"arr{i} = {arr[i]}");
                    }
                    else
                    {
                        break;
                    }
               
            }  
        }
        //power 
        public static double pow(double b , double power)
        {
            double val = Math.Pow(b, power);//native code 
            return val;
        }
        static void Main(string[] args)
        {
            #region
            //task1 run
            //int[] arr = new int[3];
            //FillArray(arr);
            //DisplayArray(arr);
            //int x =SumArray(arr);
            //Console.WriteLine(x);
            //int [] y = GettOdd(arr);
            //DisplayArray(y);
            //int[] z = GetEven(arr);
            //DisplayArray(z);
            //Console.WriteLine(GetMax(arr));
            //Console.WriteLine(GetMin(arr));
            //Console.WriteLine(GetAvg(arr));

            //task2
            //int [,] arr2 = new int[2, 2];
            //FillTwoDimArray(arr2);
            //DisplayArray2(arr2);
            ////int k = GetAvg(arr2);
            //GetColAvg(arr2);

            //4
            //char c;
            //int[,] arr3 = new int[2, 2];
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine(" 1- enter dimension \n 2-fill array \n 3-display array" +
            //        " \n 4-display row summation \n 5-display columns avg \n 6-exist ");
            //    c = char.Parse(Console.ReadLine());


            //    switch (c)
            //    {
            //        case '1':
            //            Console.WriteLine("please enter dimension");
            //            int d = int.Parse(Console.ReadLine());
            //            Console.WriteLine($"the dim of arr is {d}");
            //            break;
            //        case '2':
            //            FillTwoDimArray(arr3);
            //            break;
            //        case '3':
            //            DisplayArray2(arr3);
            //            break;
            //        case '4':
            //            GetRowSum(arr3);
            //            break;
            //        case '5':
            //            GetColAvg(arr3);
            //            break;
            //        case '6':
            //            Console.WriteLine("good luck");
            //            break;
            //    }
            //    Console.ReadKey();
            //}
            //while (c != '6');


            //int[] arr2 = new int[3] { 10, 20, 50 };
            //int [] x =concat(arr1, arr2);
            //Console.WriteLine(x);
            //int[] arr1 = new int[10];
            //checkUnique(arr1);

            //Console.WriteLine(pow(4, 2));

            #endregion
        }
    }
}
