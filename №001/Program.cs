/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
using System.Globalization;

int Second_Number(int number) {
  int arg1 =number%10;
  int arg2 = number%100;
  int  resualt = (arg2-arg1)/10;
  return resualt;
}
int numberA = int.Parse(Console.ReadLine());

int second = Second_Number(numberA);
Console.WriteLine(second);

