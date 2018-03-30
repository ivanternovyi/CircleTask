using System;


namespace TaskApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Circle[] arr;
            arr = InputData();
            Array.Sort(arr);
            DisplayArr(arr);
            Console.WriteLine("First quater circles: ");
            DisplayFirstQuaterCircles(arr);
            Console.WriteLine("Number of circles that intercepts with first one: ");
            Console.WriteLine(GetNumOfInterceptedCircles(0, arr));
            Console.ReadKey();
        }

        private static Circle[] InputData()
        {
            Console.WriteLine("Input number of circles: ");
            var size = 0;
            double x, y, rad;
            Int32.TryParse(Console.ReadLine(), out size);
            Circle[] arr = new Circle[size];
            for(var i = 0; i < size; i++)
            {
                Console.WriteLine("Input x coordinate: ");
                Double.TryParse(Console.ReadLine(), out x);
                Console.WriteLine("Input y coordinate: ");
                Double.TryParse(Console.ReadLine(), out y);
                Console.WriteLine("Input radius: ");
                Double.TryParse(Console.ReadLine(), out rad);
                arr[i] = new Circle(x, y, rad);
            }    
            return arr;
        }

        private static void DisplayArr(Circle[] arr)
        {
            if(arr == null)
                throw new Exception();
            for (var i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
        }

        private static int GetNumOfInterceptedCircles(int pos, Circle[] arr)
        {
            var num = 0;
            for (var i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                if (i == pos)
                {
                    continue;
                }
                if(arr[pos].IsIntercepted(arr[i]))
                {
                    num++;
                }
            }
            return num;
        }

        private static void DisplayFirstQuaterCircles(Circle[] arr)
        {
            if(arr == null)
                throw new Exception();

            for (var i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                if (arr[i].LiesInFirstQuater())
                {
                    Console.WriteLine(arr[i] + "Length: " + arr[i].CalculateLength());
                }
            }
        }
    }
}