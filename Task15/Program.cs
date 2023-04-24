Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (0 < number && number <=5)
{
    Console.WriteLine("Будний день, иди работай!");
}

else if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной! сегодня можешь отдохнуть...");
}

else
{
    Console.WriteLine("Неправильный ввод дынных!");
}