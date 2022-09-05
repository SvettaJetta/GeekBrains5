using System;

namespace GeekBrains05
{
    class Program
    {
        static int task34(int n)
        {
            int count = 0;
            int value;
            int[] numbers = new int[n];
            for(int i = 0; i < numbers.Length;)
            {
                Random rnd = new Random();
                value = rnd.Next(100,1000);
                
                numbers.SetValue(value,i);                             

                i++;

            }
            
            foreach(int num in numbers)
            {
                if ((num%2)==0)
                {
                    count++;
                } 
                
            }

            string output = $"Generated array: {String.Join(", ", numbers)}";
            Console.WriteLine(output);

            return count;
        }

        static int task36(int n)
        {
           int[] numbers = new int[n];

            int result = 0;
            int value;
            int len = numbers.Length;
            int pos = 0;

            for (int i = 0; i < numbers.Length;)
            {
                Random rnd = new Random();
                value = rnd.Next(Int16.MinValue, Int16.MaxValue);

                numbers.SetValue(value, i);

                i++;

            }
            if ((numbers.Length % 2 == 0))
            {
                len = numbers.Length-1;
            }

           


            for (int i = 0; i <= len / 2;)
            {
                result += numbers[pos];

                pos += 2;
                i++;

            }

            string output = $"Generated array: {String.Join(", ", numbers)}";
            Console.WriteLine(output);

            return result;

        }

        static Double task38(int n)
        {
            
            double[] numbers = new double[n];
            double min = numbers[0], max = numbers[0];
            double value;


            for(int i = 0; i < numbers.Length;)
            {
                Random rnd = new Random();
                value = Math.Round(rnd.NextDouble() + new Random().Next(Int16.MinValue,Int16.MaxValue),3);
                
                numbers.SetValue(value,i);               

                i++;

            }

            string output = $"Generated array: {String.Join(", ", numbers)}";
            Console.WriteLine(output);

            foreach (double x in numbers)
            {
                if (x > max) max = x;
                if (x < min) min = x;

            }
            Console.WriteLine($"Max ={max}, Min ={min} ");

            return max - min;

        }
        
        static  int[] task37(int n)
        {
            int[] result;
            int pos = n - 1;


            int value;
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length;)
            {
                Random rnd = new Random();
                value = rnd.Next(1, 10);

                numbers.SetValue(value, i);

                i++;

            }
            if ((n % 2) == 0)
            {
                result = new int[n/2];

                for(int i=0; i<=result.Length-1;)
                {
                    result[i] = numbers[i] * numbers[pos];

                    i++;
                    pos--;
                }
            }
            else
            {
                result = new int[(n/2)+1];
                for (int i = 0; i <= result.Length-1;)
                {
                    if (i != pos)
                    {
                        result[i] = numbers[i] * numbers[pos];

                        i++;
                        pos--;

                    }
                    else
                    {
                        result[i] = numbers[i];
                        i++;
                    }
                    
                }
            }
            string output = $"Generated array: {String.Join(", ", numbers)}";
            Console.WriteLine(output);


            return result;

        }


        static void Main(string[] args)
        {
            int n = new Random().Next(4,10);
          
            Console.WriteLine($"Your genereted numbers in arrays is: {n}");

            Console.WriteLine("task34");
            Console.WriteLine("The count of even numbers in the array ");
            Console.WriteLine("Result: "+ task34(n));
            Console.WriteLine("____________________________");

            Console.WriteLine("task36");
            Console.WriteLine("Sum of elements in odd positions ");
            Console.WriteLine("Result: "+ task36(n));
            Console.WriteLine("____________________________");

            Console.WriteLine("task38");
            Console.WriteLine("Difference between maximum and minimum array elements  ");
            Console.WriteLine("Result: "+ task38(n));
            Console.WriteLine("____________________________");

            Console.WriteLine("task37");
            Console.WriteLine("product of pairs of numbers in a one-dimensional array  ");
            Console.WriteLine("Result: "+ $"{String.Join(", ", task37(n))}");
            Console.WriteLine("____________________________");



            
        }
    }
}
