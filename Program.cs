// Задача 1.
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// void Main()
// {
//     Console.WriteLine("Введите натуральное число M: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите натуральное число N: ");
//     int n = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine($"Натуральные числа от {m} до {n}:");
//     Console.WriteLine(PrintNaturalNumbers(m, n));

// }

// string PrintNaturalNumbers(int m, int n)
// {
//     if (m == n) return Convert.ToString(n);
//     return m + ", " + PrintNaturalNumbers(m + 1, n);
// }

// Main();

// Задача 2.
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29


// void Main()
// {
//     int m = 2;
//     int n = 3;

//     Console.WriteLine($"A({m}, {n}) = {AkkerFunc(m, n)}");
// }

// int AkkerFunc(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//     {
//         return AkkerFunc(m - 1, 1);
//     }
//     else if (m > 0 && n > 0)
//     {
//         return AkkerFunc(m - 1, AkkerFunc(m, n - 1));
//     }
//     return(AkkerFunc(m,n));

// }

// Main();

// Задача 3.
// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void Main()
{
    int[] array = { 1, 2, 5, 0, 10, 34 };
    ReverseArr(array, array.Length - 1);


}

void ReverseArr(int[] array, int i)
{
    if (i < 0) return;
    Console.Write(array[i] + " ");
    ReverseArr(array, i - 1);
}

Main();