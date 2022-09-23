// Task15
Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if ((0 < dayNumber) && (dayNumber < 6)) Console.WriteLine("нет");
else if ((5 < dayNumber) && (dayNumber < 8)) Console.WriteLine("да");
else Console.WriteLine("Не существует такого номера дня в неделе");