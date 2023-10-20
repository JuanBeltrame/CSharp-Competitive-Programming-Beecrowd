/*
Link to the problem: https://www.beecrowd.com.br/judge/en/problems/view/1059
----------------------------------------------------------------------
Write a program that prints all even numbers between 1 and 100, including them if it is the case.

Input
In this extremely simple problem there is no input.

Output
Print all even numbers between 1 and 100, including them, one by row.
*/

using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                System.Console.WriteLine(i);
            }
            else
            {

            }
        }
    }
}