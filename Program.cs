/*
//1.
Console.WriteLine("Input integer number ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine("Result is "+ result);
*/

//2.
// Console.WriteLine("Input first number ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int square = num2 * num2;
// if (num1 == square)
//     Console.WriteLine("First number is square of second number"); 
// else
//     Console.WriteLine("First number is NOT square of second number");   

// 3.
// Console.WriteLine("Input number of the day: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day < 1 || day > 7){
//     Console.WriteLine("Incorrect");
// }
// else{
//     if (day == 1){
//         Console.WriteLine("Monday");
//     }
//     if (day == 2){
//         Console.WriteLine("Tuesday");
//         }    
//     }

//4.
// Console.WriteLine("Input number ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = -1 * num;
// while ( current <= num){
//     Console.Write(current + " ");
//     current++;
// }

//5.
// Console.WriteLine("Input number ");
// int num = Convert.ToInt32(Console.ReadLine());
// int a = num % 10;
// if (num < 999 & num > 99){
//     Console.WriteLine("Result is "+ a);
// }
// else {
//     Console.WriteLine("Incorrect number");
// }
   
//HomeWork 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.   
// Console.WriteLine("Input first number ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2){
//     Console.WriteLine("max=" + num1 +"; min=" + num2);
// }
// else {
//     Console.WriteLine("max=" + num2 +"; min=" + num1);
// }

//HomeWork 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//  Console.WriteLine("Input first number ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third number ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = Math.Max(num1, Math.Max(num2, num3));
// Console.WriteLine("max = "+ max);

//  Console.WriteLine("Input first number ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third number ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if ( num2 > num1) {
//     max = num2;
// }
// if ( num3 > max) {
//     max = num3;
// }
// Console.WriteLine("max = "+ max);

//HomeWork 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("Input integer number ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num%2 == 0) {
//     Console.WriteLine("chetnoe");
// }
// else {
//     Console.WriteLine("nechetnoe");
    //}

//HomeWork 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Console.WriteLine("Input number ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = 1;
// while ( current <= num){
//     if (current%2 == 0){
//         Console.WriteLine(current);
//     }
//     current++;
// }