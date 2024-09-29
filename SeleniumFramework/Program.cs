// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using NUnit;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;


class MainClass
{

    public static string[] LongestWord(string sen)
    {

        // code goes here 
        var String = sen.Split(" ");
        List<string> mylist = new List<string>();
        List<char> specialCharacters = new() { '&', '!', '@' };
        string pattern = "[0-9]";
        foreach (var i in String)
        {
            var test = i.ToCharArray();
            string newString = string.Empty;
            foreach (var j in test)
            {
                //if ()
                //    newString += j;
            }
            //mylist.Add();
        }
        return String;

    }

    public static int Factorial(int num)
    {
        //int factorial = num;
        //num--;
        //factorial=factorial*num;
        //Console.WriteLine($"{num}, {factorial}");
        if (num == 1)
        {

            return 1;
        }

        return num * Factorial(num - 1);

    }

    public static int Combination(int[] arr, int r = 2)
    {
        for (var i = 0; i < arr.Length; i++)
        {
            if (r >= 2)
                for (var j = 1; i < arr.Length; i++)
                {
                    Console.WriteLine($"{arr[i]} + {arr[j]}");
                }
        }
        return 3;

    }



    public static int LargestNumber(int[] arr)
    {
        //public static int? largest { get; set; }
        int largest = arr[0];
        foreach (var i in arr)
        {
            if (i > largest)
            {
                largest = i;
            }
        }

        return largest;
    }


    public static bool ArrayAddition()
    {
        int[] array_item = { 3, 5, 10, 18, 19, 4, 8, 12 };
        var largest_number = LargestNumber(array_item);
        List<int> MyList = new();
        foreach (var i in array_item)
        {
            if (i != largest_number)
            {
                MyList.Add(i);
            }
        }


        int Max_combinations = MyList.Count; // Number of nested loops
        int loopLimit = MyList.Count; // The limit for each loop
        int[] counters = new int[Max_combinations];
        List<int> final_output = new List<int>();


        NestedLoops(0, Max_combinations, loopLimit, counters, MyList, largest_number, final_output);
        //Console.WriteLine(final_output[0]);
        //foreach(var i in final_output)
        if (final_output.Contains(largest_number))
        {
            return true;
        }
        else
        {
            return false;
        }




    }

    static void NestedLoops(int level, int Max_combinations, int loopLimit, int[] counters, List<int> MyList, int largest_number, List<int> final_output)
    {

        if (level == Max_combinations)
        {
            //int[] array = { 5, 7, 1, 2 };
            //if (counters[0]!=counters[1])
            //{
            HashSet<int> remove_duplicates = new HashSet<int>(counters);
            Console.WriteLine(string.Join(",", counters));
            List<int> unique_values = new List<int>(remove_duplicates);
            int addition = 0;
            foreach (var index in unique_values)
            {
                //Console.WriteLine($"{MyList[index]}");
                addition += MyList[index];
            }
            if (largest_number == addition)
            {
                //Console.WriteLine(addition);
                final_output.Add(addition);
                //Console.WriteLine("True");
                //return;
            }
            //Console.WriteLine($"{MyList[counters[0]]}+{MyList[counters[1]]} counters={string.Join(", ", unique_values)}");
            //}
            return;
        }
        for (int i = 0; i < loopLimit; i++)
        {
            counters[level] = i;
            //Used recursive function to increase the loops i.e nested loops
            NestedLoops(level + 1, Max_combinations, loopLimit, counters, MyList, largest_number, final_output);
        }

    }



    static void Main()
    {

        //Console.WriteLine(LongestWord(Console.ReadLine()));
        Console.WriteLine(ArrayAddition());
        //Combination(new int[] { 5, 7, 1, 2 });
        //Console.WriteLine(Factorial(5));

    }
}

