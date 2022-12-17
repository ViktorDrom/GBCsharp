// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


//  Console.WriteLine("Input first number ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number ");
// int b = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if (a > b)
// {
//     Console.WriteLine($"{a} больше {b}");
// }
// else
// {
//     Console.WriteLine($"{b} больше {a}");
// }




// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Input first number ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input first number ");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if (b > max) max = b;
// if (c > max) max = c;

// Console.WriteLine(max);





// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> неn


// Console.Write("Input number ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a % 2 == 0)
// {
//     Console.WriteLine($"{a} -> YES");
// }
// else
// {
//     Console.WriteLine($"{a} -> NO");
// }





// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Не знал как сделать, чтобы выводилось именно вот в таком виде "8->2 4 6 8" просто перечислением без "8->" сделать не проблема


// Console.WriteLine("Input N ");
// int N = Convert.ToInt32(Console.ReadLine());

// int i = 1;

// if (N > i)
// {
//     while (i < N)
//     {
//         i = i + 1;
//         if (i % 2 == 0)
//         {
//             Console.Write($"{N}->");
//             while(i<=N)
//             {
//             Console.Write(i+" ");
//             i = i + 2;
//             }
//         }
//     }
// }
// else
// {
//     Console.WriteLine("Input another N ");
// }


// это тоже работает, он компактнее, но выводит в несколько строчек, и ничего не делает при N < 1


// Console.WriteLine("Input N ");
// int N = Convert.ToInt32(Console.ReadLine());

// int i = 1;

//  while (i < N)
//  {
//      i = i + 1;
//      if (i % 2 == 0)
//     {
//         Console.WriteLine($"{N} -> {i}");
//     }
// }    
