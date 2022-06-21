//HomeWork 2
// /HomeWork 2.1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void ShowSecondNumber() {
    int num = new Random().Next(100,1000);
    int num1 =  num/100;
    int num3 = num%10;
    int num2 = (num - num1*100 - num3)/10;
    Console.WriteLine(num + "->" + num2);
}
ShowSecondNumber();


///HomeWork 2.2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// void ShowThirdNumber(int n1){
//     int num = n1.ToString().Length;
//     // Console.WriteLine(num);
//     if (num<3) {
//         // Console.WriteLine(n1 + "- третьей цифры нет");
//     }
//     else {
//         int x =10;
//         int stepen = (num - 3);
//         int result = Convert.ToInt32(Math.Pow(x,stepen));
//         // Console.WriteLine(result);
//         int third = (n1/result)%10;
//         Console.WriteLine(third);
//     }
// }

// Console.Write("Введите число ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// ShowThirdNumber(n1);

///HomeWork 2.3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// void Weekend(int day){
//     if (day < 1 || day > 7){
//     Console.WriteLine("Incorrect");
//     }
//     else{
//     if (day == 6 || day == 7){
//         Console.WriteLine("Выходной");
//     }
//     else {
//         Console.WriteLine("Не выходной");
//     }
//     }
// }
// Console.Write("Введите число ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Weekend(n1);




//Seminar 2
//1.
// void showNumber() {
//     int num = new Random().Next(10,100);
//     int num1 =  num/10;
//     int num2 = num%10;
//     Console.Write(num + "->" );
//     if (num1>num2){
//         Console.Write(num1);
//     }
//     else {
//         Console.Write(num2);
//     }
// }

// showNumber();

//2. 
// void delNumber() {
//     int num = new Random().Next(100,1000);
//     int num1 =  num/100;
//     int num3 = num%10;
//     int num2 = (num - num1*100 - num3)/10;
//     Console.WriteLine(num);
//     Console.Write(num1);
//     Console.Write(num3);
// }
// delNumber();

//3.
// void ShowDifference(int num1, int num2) {
//     if (num2%num1 == 0){
//         Console.WriteLine(num2 + " кратно"  + num1);
//     }
//     else {
//         int num3 = num2%num1;
//         Console.WriteLine(num2 + " некратно " + num1 + ", остаток " + num3);
//     }
// }
// Console.Write("Введите первое число ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// ShowDifference(n1, n2);


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





