// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// int ShowSecondNumber(int num)
//         {
//             int sot = num / 100;
//             num = num - sot * 100;
//             return num / 10;
//         }

// Console.Write("Введите трехзначное число ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ShowSecondNumber(num));





// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6



// Свое решение:


// int ShowThirdNumber (int num)
// {
//     if(num >= 100  && num < 1000)
//     {
//         num = num % 10;
//         return num;
//     }
//     else
//     {
//         if (num >= 1000)
//         {
//             while(num >= 1000)
//             {
//                num = num / 10;
//             }
//         num = num % 10;
//         return num;
//         }
//         else 
//         {
//             Console.WriteLine($"{num} -> Третьей цифры нет");
//             return num;
//         }
//     }
// }

// Console.Write ("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine ());
// Console.WriteLine(ShowThirdNumber(num));




// Пример из интерната

// Console.Write("Введи число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2){
//   Console.WriteLine("третья цифра -> " + anyNumberText[2]);
// }
// else {
//   Console.WriteLine("-> третьей цифры нет");
// }







// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



// int HolidaysNumber(int num)
// {
//     if(num > 5)
//     {
//         Console.WriteLine($"{num} -> yes ");
//         return num;
//     }
//     else
//     {
//         Console.WriteLine($"{num} -> no ");
//         return num;
//     }
// }

// int randomNumber = new Random().Next(1, 8);
// Console.WriteLine(randomNumber);
// int result = HolidaysNumber(randomNumber);