using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02_dz
{
    internal class Program
    {
        public static void Random(int[] a)
        {
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(0, 5);
            }
        }
        public static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0,4}", a[i]);
            }
            Console.WriteLine();
        }
        public static void FirstTask(int[] a)
        {
            int temp = 1;
            foreach (var i in a)
            {
                if (i % 2 == 1 && i > temp) //находим самый большой элемент
                {
                    temp = i; 
                }
            }
            Console.WriteLine($"The biggest odd element: {temp}");
            
            for (int i = 0; i < a.Length; i++)
            {
                if (temp == a[i])
                {
                    temp = i;
                    temp++; // находим элемент который справа от наибольшего нечётного
                    break;
                }
            }
            int first_elem = a[temp];
            for (int i = 0; i < 3; i++)
            {
                for (int j = temp; j < a.Length - 1; j++)
                {
                    a[j] = a[j + 1];
                }
                a[a.Length - 1] = first_elem;
                first_elem = a[temp];
            }
            Print(a);
        }
        public static void SecondTask(int[] a)
        {
           int sum = 0;
           int buff = 0;
            for (int i = 0; i < a.Length; i++) // проходим по циклу
            {
                if (buff > 0) 
                {
                    sum += a[i]; // увеличиваем сумму
                }
                if (a[i] == 0)
                {
                    buff++;
                    if (buff > 1) break; // в диапазоне между двумя нулями
                }
            }
            if (buff < 2) //если не нашли
                sum = 0;
            Console.WriteLine($"\nSum = {sum}");
        }
        public static void ThirdTask(int[] a)
        {
            int counter = 0;
            Console.WriteLine("There will be 3 elements in subsets. \nEnter sum that you want to find: "); //не совсем по заданию, в данном случае выходит что у нас подмножество из 3х элементов

            int sum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a.Length - 2; i += 3)
            {
                if (sum == a[i] + a[i + 1] + a[i + 2]) // сравнение введенного числа с суммой
                {
                    Console.WriteLine($"Got a subset: {a[i]}    {a[i + 1]}    {a[i + 2]}");
                    counter++; //счетчик результатов
                }
            }
            Console.WriteLine($"Number of subsets is: {counter}");
        }
        static void Main(string[] args)
        {
            int[] Array = new int[15];
            Random(Array);
            Print(Array);
            FirstTask(Array);
            SecondTask(Array); Console.WriteLine();
            ThirdTask(Array); Console.WriteLine();
        }
    }
}
