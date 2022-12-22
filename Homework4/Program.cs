// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// double Stepen (double A, double B)
// {
//    double i = Math.Pow(A, B);
//    return i;
// }

// Console.WriteLine("Input A:");
// double A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B:");
// double B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Stepen (A, B));




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Здесь просто хотел попробовать через строчки, но не получилось. 

// string Summa(string num)
// {
//     string result = string.Empty;
//     int length = num.Length;
//     for(int i = 0; i < length; i++)
//     {
//     //    result = result + num[i];
//         result = result + $"{num[i]}";
//     }
//     return result;
// }
// Console.WriteLine("Input number: ");
// string number =Convert.ToString(Console.ReadLine());
// Console.WriteLine(Summa(number));


// Это рабочий вариант решения данного задания


// int Summa(int num)
// {
//     int sum = 0;
//     for(int i = 0; num!=0; i++)
//     {
//         sum = sum + num % 10;
//         num = num / 10;
//     }
//     return sum;

// }
// Console.Write("Input number: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Summa(A));





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// int[] CreateRandomArray (int size,int minValue, int maxValue)
// {
//     int[] myArray = new int[size];
//     for(int i=0;i<size;i++)
//     {
//         myArray[i] = new Random().Next(minValue,maxValue+1);
//     }
//     return myArray;
// }

// void ShowArray (int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());
// ShowArray(CreateRandomArray(lenght,min,max));