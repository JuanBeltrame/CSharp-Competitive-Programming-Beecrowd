/*
Link to the problem: https://www.beecrowd.com.br/judge/en/problems/view/1003
----------------------------------------------------------------------
Read two integer values, 
in this case, the variables A and B. 
After this, calculate the sum between them and assign it to the variable SOMA. 
Write the value of this variable.

Input
The input file contains 2 integer numbers.

Output
Print the message "SOMA" with all the capital letters, 
with a blank space before and after the equal signal 
followed by the corresponding value to the sum of A and B. 
Like all the problems, don't forget to print the end of line, otherwise you will receive "Presentation Error"
*/
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        int sum = number1 + number2;
        Console.WriteLine("SOMA = {0}",sum);
    }
}   