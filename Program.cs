// Task13
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 100 < 1) Console.WriteLine("Третьей цифры нет");
else 
{
    Console.WriteLine("Третья цифра числа:");
    Console.WriteLine((number % 10) % 100);
}
