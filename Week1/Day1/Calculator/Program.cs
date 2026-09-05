Console.WriteLine("Калькулятор");

int number1;
while(true)
{
Console.WriteLine("Введите первое число: ");
string input1 = Console.ReadLine();

if (int.TryParse(input1, out number1))
    {
        break;
    }
    else
    {
        Console.WriteLine("Это не число! Попробуй еще раз");
    }
}

Console.WriteLine("Выберите операцию (+, -, *, /)");
string operation = Console.ReadLine();

int number2;
while(true)
{
Console.WriteLine("Введите второе число: ");
string input2 = Console.ReadLine();

if (int.TryParse(input2, out number2))
    {
        break;
    }
    else
    {
        Console.WriteLine("Это не число! Попробуй еще раз");
    }
}

if (operation == "+")
{
int result = number1 + number2;
Console.WriteLine($"{number1} {operation} {number2} = {result}");
}
if (operation == "-")
{
int result = number1 - number2;
Console.WriteLine($"Результат: {result}");
}
if (operation == "*")
{
int result = number1 * number2;
Console.WriteLine($"Результат: {result}");
}
if (operation == "/")
{
    if (number2 ==0)
    {
        Console.WriteLine("Ошибка, даление на ноль");
    }
    else
    {
int result = number1 / number2;
Console.WriteLine($"Результат: {result}");
    }
}
else
{
    Console.WriteLine("Неизвестная операция");
}