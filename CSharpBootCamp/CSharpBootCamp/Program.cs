using System;
using System.Diagnostics;

namespace CSharpBootCamp
{
    class Program
    {
        static int[] array;

        static void Main(string[] args)
        {
            // Try all those Demos one by one to learn about loops and arrays;

            //DemoOutOfRange();

            //DemoAppendToArray();

            //DemoNullReference();

            //DemoPassByReference();

            //StringDemo();

            //SuboptimalLoopComparisonDemo();
        }

        private static void SuboptimalLoopComparisonDemo()
        {
            var sw = new Stopwatch();
            sw.Start();
            SlowSertedNumbersPrint();
            sw.Stop();
            Console.WriteLine("Slow sort took: " + sw.ElapsedMilliseconds);
            sw.Reset();

            sw.Start();
            FastSertedNumbersPrint();
            sw.Stop();
            Console.WriteLine("Fast sort took: " + sw.ElapsedMilliseconds);
            sw.Reset();
        }

        private static void SlowSertedNumbersPrint()
        {
            int[] unsortedArray = new int[2048];
            Console.WriteLine("The first 100 numvers are:");
            for (int i = 0; i < 99; i++)
            {
                // DO NOT sort inside a loop or do any other complex number.
                int[] sortedArray = Sort(unsortedArray);
                Console.WriteLine(sortedArray[i]);
            }
        }
        private static void FastSertedNumbersPrint()
        {
            int[] unsortedArray = new int[2048];
            Console.WriteLine("The first 100 numvers are:");

            // Sort the array outside of the loop and then print the results.
            int[] sortedArray = Sort(unsortedArray);
            for (int i = 0; i < 99; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }
        }
        private static int[] Sort(int[] array)
        {
            int[] result = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                for (int ii = 0; ii < array.Length; ii++)
                {
                    result[ii] = ii;
                }
            }
            return result;
        }

        private static void StringDemo()
        {
            var name = "youssef";
            Console.WriteLine("Before: " + name);
            CapitalizeFirstLetterV1(name);
            // prints youssef.
            Console.WriteLine("After V1: " + name);

            name = CapitalizeFirstLetterV2(name);
            // prints Youssef.
            Console.WriteLine("After V2: " + name);
        }


        private static void CapitalizeFirstLetterV1(string name)
        {
            // string is immuatable, won't work!
            // name[0] = "Y";

            var firstLetter = name[0].ToString().ToUpper();
            name = firstLetter + name.Substring(1, name.Length - 1);

            Console.WriteLine("In between V1: " + name);

        }

        private static string CapitalizeFirstLetterV2(string name)
        {
            // string is immuatable, won't work!
            // name[0] = "Y";

            var firstLetter = name[0].ToString().ToUpper();
            name = firstLetter + name.Substring(1, name.Length - 1);

            Console.WriteLine("In between V2: " + name);

            return name;
        }

        private static void DemoPassByReference()
        {

            var array = new[] { 1, 2, 3};
            SetAllElementsOfArrayTo(array, 10);
            foreach(var number in array)
             {
                 Console.Write(number + " ");
             }
        }

        private static void SetAllElementsOfArrayTo(int[] array, int number)
        {
            for(int i = 0; i<array.Length; i++)
            {
                array[i] = number;
            }

            // No need to return anything- changes persisted.
        }

        private static void DemoNullReference()
        {
            // Null reference exeption
            Console.WriteLine(array[0]);
        }

        private static void DemoOutOfRange()
        {
            var array = new int[0];
            // IndexOutOfRangeException
            Console.WriteLine(array[0]);
        }

        private static void DemoAppendToArray()
        {
            // Emty array
            var array = new int[0];

            // New array with one element. {10}
            var expandedArray = AppendToArray(array, 10);


            // To print all elements:
            foreach(var number in expandedArray)
            {
                Console.Write(number + " ");
            }

            // Will not print all elements.
            // Prints System.int32[].
            // DO NOT print array object, print array elements
            Console.WriteLine(expandedArray);
        }

        private static int[] AppendToArray(int[] array, int numberToBeAdded)
        {
            // Expand the array
            var array2 = new int[array.Length + 1];

            // Copy elements over
            for(var i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }

            // Fillthe last spot with the number to be added.
            array2[array2.Length - 1] = numberToBeAdded;

            return array2;
        }
    }
}
