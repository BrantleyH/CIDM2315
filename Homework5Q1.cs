﻿namespace Homework5Q1;
using System;
public class Largest1
{
   public static int largest(int n1, int n2)
   {
    if (n1 > n2)
    {
        return n1;
    }
    else
    {
        return n2;
    }
}
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first integer: ");
            int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second integer: ");
            int second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largest(first, second));
    }
}