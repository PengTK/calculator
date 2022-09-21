int answer, result;
float number1, number2;
Console.WriteLine("1.Сложить 2 числа \n2.Вычесть первое из второго \n3.Перемножить два числа \n4.Разделить первое на второе \n5.Возвести в степень N первое число \n6.Найти квадратный корень из числа \n7.Найти 1 процент от числа \n8.Найти факториал из числа \n9.Выйти из программы");
while (true)
{
    Console.WriteLine("Введите номер операции");
    answer = Convert.ToInt32(Console.ReadLine());
    if (answer != 9)
    {
        Console.WriteLine("Введите первое число");
        number1 = Convert.ToInt32(Console.ReadLine());

        switch (answer)
        {
            case 1:
                Console.WriteLine("Введите второе число");
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Результат: {number1 + number2}");
                break;
            case 2:
                Console.WriteLine("Введите второе число");
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Результат: {number2 - number1}");
                break;
            case 3:
                Console.WriteLine("Введите второе число");
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат: " + number1 * number2);
                break;
            case 4:
                Console.WriteLine("Введите второе число");
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат: " + number1 / number2);
                break;
            case 5:
                Console.WriteLine("Введите второе число");
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат: " + Math.Pow(number1, number2));
                break;
            case 6:
                Console.WriteLine("Результат: " + Math.Sqrt(number1));
                break;
            case 7:
                Console.WriteLine("Результат: " + number1 * 0.01);
                break;
            case 8:
                result = 1;
                for (int i = 1;  i <= number1; i++)
                {
                    result = result * i;
                }
                Console.WriteLine("Результат: " + result);
                break;

        }
    }
    else Environment.Exit(0);
}