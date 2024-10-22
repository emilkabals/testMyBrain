
Console.WriteLine("__Добро пожаловать в консольный калькулятор__");
Console.WriteLine("_______________________________");

bool exit  = false;

while (!exit)
{
    Console.WriteLine("Введите первое число");
    double number1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите операцию (+, -, *, /)");
    string operation = Console.ReadLine();
    Console.WriteLine("Введите второе число");
    double number2 = Convert.ToDouble(Console.ReadLine());

    double result = 0;

    switch (operation)   {
        case "+":
            result = number1 + number2;
            break;
        case "-":
            result = number1 - number2;
            break;
        case "*":
            result = number1 * number2;
            break;
        case "/":
            if (number2 == 0)
            {
                Console.WriteLine("На ноль делить нельзя!!!");
            }
            else {
                result = number1 / number2;
            }
            break;
            default:
            Console.WriteLine("Ошибка! Неизвестная операция!");
            continue;
    }

    Console.WriteLine("Результат: " + result);



    Console.WriteLine("Хочешь продолжить? (Y/N)");
    string end = Console.ReadLine();
    if (end == "n" || end == "N") {
        exit = true;
    }

    
}   


