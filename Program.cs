// Первая задача
// Console.WriteLine("input integer number");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num;
// Console.WriteLine("result is" + result);

// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// Console.WriteLine("input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2*num2){
//     Console.WriteLine("first number is a square of second number:");
// }
// else {
//     Console.WriteLine("first number is not a square of second number:");
// }

// Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// Console.WriteLine("input number of a day: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7){
//     Console.WriteLine("incorrect day");
// }
// else {
//     if (day == 1){
//        Console.WriteLine("monday"); 
//     }
//     if (day == 2){
//        Console.WriteLine("tuesday"); 
//     }
//     if (day == 3){
//        Console.WriteLine("wensday"); 
//     }
// 

// 4. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
 
//  Console.WriteLine("input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current;
// if (num < 0){
//     current = num;
//     num = num * (-1);
// }
// else {
//     current = -1 * num;
// }
// while (current < num-1){
//     current++;
//     Console.Write(current + " ");
// }

// 5. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// Console.WriteLine("input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num % 10);



// ДОМАШНЕЕ ЗАДАНИЕ

// 1) Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1>num2){
//    Console.WriteLine("max: " + num1);
//    Console.WriteLine("min: " + num2);
// }
// else {
//    Console.WriteLine("max: " + num2);
//    Console.WriteLine("min: " + num1);
//     }


// 2) Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.WriteLine("input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input third number");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max=0;
// if (num1>num2){
//     max=num1;
// }
// else {
//     max=num2;
// }
// if (max<num3){
//     max=num3;
// }
// Console.WriteLine("max number is " + max);


// 3) Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0){
//     Console.WriteLine(num + " - четное число");
// }
// else{
//     Console.WriteLine(num + " - не четное число");
// }


// 4) Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Console.WriteLine("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current;
// if (num < 0){
//     current = num;
//     num = num * (-1);
// }
// else {
//     current = -1 * num;
// }
// while (current < num-1){
//     current++;
// if (current % 2 == 0){
//     Console.Write(current + " ");}
// }
