// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return myArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// void NumbersAboveZero(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++) 
//     {
//        if(array[i] > 0) count++;
//     }
//     Console.WriteLine($"{count} чисел больше нуля");

// }
// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
// int max = Convert.ToInt32(Console.ReadLine());                                  

// int[] newArray = CreateRandomArray(lenght,min,max);

// ShowArray(newArray);
// NumbersAboveZero(newArray);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = -((b1 - b2) / (k1 - k2));
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    // double y = y1 = y2; Я не знаю нужна ли такую строчку добавлять, чтобы в ответе указывать просто y в 63 строке? В ответе напишите это, пожалуйста.
    Console.WriteLine($"Точка пересечения заданных прямых ({x};{y2})");
}
Console.WriteLine("Задайте первую прямую:");
double k1 = Convert.ToInt32(Console.ReadLine());
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте вторую прямую:");
double k2 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
CrossPoint(k1, b1, k2, b2);