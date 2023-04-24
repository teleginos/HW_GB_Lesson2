Console.WriteLine("Введите трех значное число :");
int number = Convert.ToInt32(Console.ReadLine());

if (100 < number && number < 1000)
{
    Console.WriteLine($"Вторая цифра числа {number} = {number % 100 / 10}");
}

else
{
    Console.WriteLine("Неправильный ввод данных!");
}