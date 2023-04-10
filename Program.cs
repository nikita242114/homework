case 1:

// Задача 2:  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Ведите число");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите второе чилсло");

int b = Convert.ToInt32(Console.ReadLine());

if (a > b)

System.Console.WriteLine( + a + b);

else System.Console.WriteLine($"Большее число: {a}, меньшее число: {b}");

case 2:

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");

int num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");

int num_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");

int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (max < num_2) max = num_2;

if (max < num_3) max = num_3;

System.Console.WriteLine("Максимальное из этих чисел =" + max);

case 3:

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");

int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)

System.Console.WriteLine("Число: " + a + " четное");

else System.Console.WriteLine($"Число: {a} нечетное");

case 4:

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N");

int n = Convert.ToInt32(Console.ReadLine());

for(int i=1;i<=n;i++)

{
if (i % 2 == 0)
System.Console.Write(i + ",");
}