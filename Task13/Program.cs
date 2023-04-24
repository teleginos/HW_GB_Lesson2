Console.Write("Введите число: ");
string numberstr = Console.ReadLine();
int count = 1;

if (numberstr.Length > 2)
{
    count += numberstr.Length - 3;
    int number = Convert.ToInt32(numberstr);
    int number2 =Convert.ToInt32(Math.Pow(10, count));
    Console.WriteLine($"Третья цифра числа {number} = {(number % number2) / (number2 / 10)}");
}

else
{
    Console.WriteLine("Третьей цифры нет");
}