bool Verify(dynamic arg)
{
    if (arg.GetTypeCode() == TypeCode.Int32)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
dynamic Task25(dynamic arg1, dynamic arg2)
{
    if (Verify(arg1) == true && Verify(arg2) == true)
    {
        int result = 1;

        for (int i = 0; i < arg2; i++)
        {
            result *= arg1;
        }
        return result;
    }
    else
    {
        return "error";
    }
}


System.Console.WriteLine();


System.Console.WriteLine($"task 25 = {Task25(3, 5)}");
System.Console.WriteLine($"task 25 = {Task25(2, 4)}");
System.Console.WriteLine($"task 25 = {Task25(5, 3)}");
System.Console.WriteLine($"task 25 = {Task25('a', 3)}");
System.Console.WriteLine($"task 25 = {Task25(5, '2')}");
System.Console.WriteLine($"task 25 = {Task25('b', 'g')}");


System.Console.WriteLine();


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
dynamic Task27(dynamic arg)
{
    if (Verify(arg) == true)
    {
        string intToString = Convert.ToString(arg);
        int result = 0;

        foreach (char i in intToString)
        {
            int stringToInt = (int)Char.GetNumericValue(i);
            result += stringToInt;
        }
        return result;
    }
    else
    {
        return "error";
    }
}


System.Console.WriteLine($"task 27 = {Task27(425)}");
System.Console.WriteLine($"task 27 = {Task27(82)}");
System.Console.WriteLine($"task 27 = {Task27(9012)}");
System.Console.WriteLine($"task 27 = {Task27(123456789)}");
System.Console.WriteLine($"task 27 = {Task27('4')}");
System.Console.WriteLine($"task 27 = {Task27('a')}");


System.Console.WriteLine();


// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
dynamic Task29(dynamic arg)
{
    if (Verify(arg) == true)
    {
        int[] arr = new int[arg];
        Random rnd = new Random();

        for (int i = 0; i < arg; i++)
        {
            arr[i] = rnd.Next(0, 50);
        }

        return arr;
    }
    else
    {
        return "error";
    }
}


Console.WriteLine($"task 29 = [{string.Join(", ", Task29(8))}]");
Console.WriteLine($"task 29 = [{string.Join(", ", Task29('1'))}]");
Console.WriteLine($"task 29 = [{string.Join(", ", Task29('b'))}]");
