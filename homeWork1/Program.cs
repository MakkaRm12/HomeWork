// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.WriteLine("Введите трёхзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 >= 100 && number1 < 1000)
{
  int  number2 = number1 / 10;
  int  number3 = number2 % 10;
    Console.WriteLine($"Второе число {number3}");
}
else
{
  Console.WriteLine("Вы ввели не трёхзначное число");

}