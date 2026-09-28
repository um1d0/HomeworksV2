using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
#region 1
/* int positive = 0;
int negative = 0;
int zero = 0;
int[] Numbers = { 1, 2, 3, 4, 5,-2,-5, -1,0,0 };
for (int i = 0; i < Numbers.Length; i++)
{
   
    if (Numbers[i] > 0)
    {
        positive++;
    }
    else if (Numbers[i] < 0)
    {
        negative++;
    }
    else
    {
        zero++;

    }
}
Console.WriteLine($"there are {positive} positive and {negative} negative numbers also {zero} zero ");  */
#endregion
#region 2
/*int[] numbers = [1, 9, 12, 509, 123, 3, 35, 6,];
Decimal total = 0;
for (int i = 0; i < numbers.Length; i++)
{
    total += numbers[i];
}
Console.WriteLine(total);
Console.WriteLine(total / numbers.Length);
*/




#endregion
#region 3
/*  int[] numbers = { 7, 2, 15, 4, 9, 21, 3 };
int max = numbers[0];
int min = numbers[0];

for (int i = 1;  i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
Console.WriteLine($"max:{max}");
Console.WriteLine($"min:{min}");
*/
#endregion

#region 4
/*
int[] numbers = [1, 9, 12, 509, 123, 3, 35, 6,2,4];
Decimal total = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 5)
    {
        total += numbers[i];

    }
}
Console.WriteLine(total);
*/

#endregion
#region 5
/*
int[] numbers = { 2, 5, 2, 7, 8, 2, 5, 2 };
Console.WriteLine("write a number");

bool isValid = int.TryParse(Console.ReadLine(), out int number);
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == number)
    {
        count++;
    }
}
Console.WriteLine($"there is {count} {number}s in this array");

*/
#endregion
#region 6
/*
int[] grades = { 91, 55, 73, 42, 88, 67, 100, 49 };
int passingCount = 0;
int failingCount = 0;
int highgradeCount = 0;
for (int i = 0; i < grades.Length; i++)
{
    
    if (grades[i] >= 90 && grades[i] >= 51)
    {
        highgradeCount++;
    }
    else if (grades[i] >= 51)
    {
        passingCount++;
    }
    else
    {
        failingCount++;
    }
}
Console.WriteLine($"{passingCount} passed the test");
Console.WriteLine($"{failingCount} failed the test");
Console.WriteLine($"{highgradeCount} got high grade");

*/

#endregion
#region 7

/*
int[] numbers = { -3, 5, -8, 10, 0, -2 };
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < 0)
    {
        numbers[i] = 0;
    }
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]},");
}
*/
#endregion

#region
/*
int[] numbers = { 5, 12, 3, 25, 8, 19 };
int max = numbers[0];
int secondMax = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] > secondMax && numbers[i] != max)
    {
        secondMax = numbers[i];
    }
}

Console.WriteLine(secondMax);
*/

#endregion