//Программа которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа
//78 - 8
//94 - 9
//07 -7

// int MaxNumber (int num)
// {
//     int a = num/10;
//     int b = num%10;
//     if(a>b)
//     {
//         return a;
//     }
//     else
//     {
//         return b;
//     }
// }

// int randomNumber = new Random().Next(10,99+1); //создает рандомные числа в диапозоне двухзначных чисел
// Console.WriteLine(randomNumber);
// int result = MaxNumber(randomNumber);
// Console.WriteLine(result);

// программа которая вводит случайное трехзначное число и удаляет число по середине

// int DeleteNumber (int Num)
// {
//     int sot = Num / 100;
//     int ed = Num % 10;
//     return sot*10 + ed;
// }
// int randomNumber = new Random().Next(100,1000);
// Console.WriteLine(randomNumber);
// int result = DeleteNumber(randomNumber);
// Console.WriteLine(result);

// Программа, которая будет принемать на вход два числа и выводить, является ли второе число кратным первому, если второе число не кратно первому то выаодить отстаток.

// void kratnost( int num1,int num2)
// {
//     if(num2%num1==0)
//     {
//         Console.WriteLine($"{num1},{num2} -> кратно");
//     }
//     else
//     Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num2%num1}");
// }
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// kratnost(num1,num2);

// Программа которая принемает на вход число и проверяет кратно ли оно 7 и 23 одновременно

// 14 - нет
// 46 -нет
// 161 - да

// bool kratnost(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         return true;
//     }
//     else
//     return false;
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool result = kratnost(num);
// Console.Write(result);