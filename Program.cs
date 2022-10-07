//  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.//

/*
Console.WriteLine("Input a number: " );
int n = Convert.ToInt32(Console.ReadLine());
 if (n>99 & n<1000)
{
    int a = n / 10;
    int b = a%10;
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Incorrect number");
}
*/



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n>=1 & n<=5)
{
    Console.WriteLine("no");
}
if (n==6 | n==7)
{
      Console.WriteLine("yes");
}
else
{
    Console.WriteLine("wrong number");
}
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


/*
Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n>999 | n<-999)
{
   n = n/10 ;
}
if (n>=100 & n<=999)
{
    int a= n %10;
    Console.WriteLine($"The third number is {a}");
}
if (n<=-100 & n>=-999)
{
    int c= n %10;
    Console.WriteLine($"The third number is {-c}");
}
else
{
Console.WriteLine("There is no third number");
}
*/




