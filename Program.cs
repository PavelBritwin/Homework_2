// Task13
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberStr = number.ToString();

if (number < 100) Console.WriteLine("Третьей цифры нет");
else 
{
    Console.WriteLine("Третья цифра числа:");
    Console.WriteLine(numberStr[2]);
}
