// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



// void CheckPalindrom (int num)
// {
//     if(num > 9999 && num < 100000)
//     {
//         int left = num  / 10000;
//         int right = num % 10;
//         if(left == right)
//         {
//             int left2 = num/1000 - left*10;
//             int right2 = (num%100 - right)/10;
//             if(left2 == right2)
//             {
//                 Console.WriteLine("YES");
//             }
//             else
//             {
//                 Console.WriteLine("NO");
//             }
//         }
//         else
//         {
//             Console.WriteLine("NOT");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Invalid num!");
//     }
// }
// Console.WriteLine("Введите пятизначное число ");
// int num = Convert.ToInt32(Console.ReadLine());
// CheckPalindrom(num);



// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

// Результаты по числам отличаются от ваших, но скорее всего просто формула другая. Эту я загуглил


// double Distance (double xA, double yA, double zA, double xB, double yB, double zB)
// {
//     double kx = xB - xA;
//     double ky = yB - yA;
//     double kz = zB - zA; 
//     double g =Math.Round(Math.Sqrt(kx*kx+ky*ky+kz*kz),1);
//     return g ;
// }

// Console.WriteLine("Координаты xA:");
// double xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты yA:");
// double yA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты zA:");
// double zA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты xB:");
// double xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты yB:");
// double yB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты zB:");
// double zB = Convert.ToInt32(Console.ReadLine());


// double result = Distance(xA, yA, zA, xB, yB, zB);
// Console.WriteLine(result);



// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



// void N(int number)
// {
    
//     for (int i = 1; i <= number; i++)
//     {
//             Console.WriteLine (i*i*i);
//     }
// }

// Console.WriteLine("Введите число:");
// int x = Convert.ToInt32(Console.ReadLine());
// N(x);
