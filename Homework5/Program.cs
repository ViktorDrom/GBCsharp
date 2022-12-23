// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


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

// void Chetnye(int[] array)
// {
//     int Count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             Count++;
//     }
//     Console.WriteLine($"Количество четных элементов массива равно {Count}");
// }

// Console.WriteLine("Введите число элементов массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(length, min, max);

// ShowArray(newArray);
// Chetnye(newArray);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



// Комментарий: 0 - считаю четным числом, поэтому i=0 пропустил, и начал сразу с i=1


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

// void SummaNechetnye(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i = i+2 )
//     {
//         sum = sum + array[i];
//     }
//     Console.WriteLine($"Сумма элементов на нечетных позициях массива равна {sum}");
// }

// Console.WriteLine("Введите число элементов массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(length, min, max);

// ShowArray(newArray);
// SummaNechetnye(newArray);




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


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

// void DiffMaxMin(int[] array)
// {
//     int top = array[0];
//     int bot = array[0];
//     for (int i = 0; i < array.Length; i++ )
//     {
//         if(array[i] > top) top = array[i];
//         if(array[i] < bot) bot = array[i];
//     }
//     int diff = top - bot;
//     Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {diff}");
// }

// Console.WriteLine("Введите число элементов массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(length, min, max);

// ShowArray(newArray);
// DiffMaxMin(newArray);