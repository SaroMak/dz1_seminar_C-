//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3 

Console.Clear();

Console.WriteLine(" введите первое число ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" введите второе число ");

int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)

Console.WriteLine ($"число {number1} > числа {number2}");

else

Console.WriteLine ($"число {number2} > числа {number1}");