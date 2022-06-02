using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_3_task_1
{
    class task1
    {
        static void Main(string[] args)
        {

            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("The list of numbers given :");
            foreach (var number in numbers)
            {
                Console.WriteLine(number + " ");
            }

            Console.WriteLine("Input the k :");
            int k = int.Parse(Console.ReadLine());
            
            for (int index = numbers.Count - 1;index>=0;index --)
            {
                
                if (numbers[index] == k)
                {
                    numbers.RemoveAt(index);
                }
               
            }
            
            for (int index = numbers.Count-1;index>=k;index--)
            {
                
                numbers.Insert(0, numbers[numbers.Count-1]);
                numbers.RemoveAt(numbers.Count-1);

            }
            if (k > numbers.Count || k < 0 )
            {
                Console.WriteLine("The array doesn't include an element with such an index!");
            }

            else
            {
                Console.WriteLine();

                numbers.ForEach(number => Console.WriteLine(number + " "));
            }
           

        }

    }
}
