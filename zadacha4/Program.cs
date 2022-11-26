// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine(" Ведите число: ");

int number = int.Parse(Console.ReadLine());

int evennum = 2; //первое четное число

if(number < 2 )

Console.WriteLine(" четных чисел нет");
Console.WriteLine( evennum  );

while(evennum  < number )
     {evennum = evennum + 2;
     Console.WriteLine( evennum  );
     };
  