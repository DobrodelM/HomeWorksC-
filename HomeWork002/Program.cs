// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int numberA = new int();
numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = new int();
numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
Console.WriteLine($"Число {numberA} является большим, число {numberB} - меньшим.");
else if (numberB > numberA)
Console.WriteLine($"Число {numberB} является большим, число {numberA} - меньшим.");
else if (numberA == numberB)
Console.WriteLine("Числа равны между собой.");
