

//HomeWork 3
// /HomeWork 19: *Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.

int Polimdrom(int n) {
int reverse = 0;
while (n!=0){
    reverse = reverse *10;
    reverse = reverse + n %10;
    n=n/10;
    }
return reverse;    
}

Console.WriteLine("Input number:");
int num = Convert.ToInt32(Console.ReadLine());
int result = Polimdrom(num);
int l = num.ToString().Length;
if (l!=5){
    Console.WriteLine("Введите 5-ое число");
}
else if (num== result){
     Console.WriteLine("Введенное число является палиндромом");
}
else {
        Console.WriteLine("Введенное число НЕ является палиндромом");
    }


// /HomeWork 22: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// void Distance3d (int x1, int x2, int y1, int y2, int z1, int z2){
//       double dist3 =Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)); 
//       Console.WriteLine("Расстояние между точками: " + dist3);
// }
// Console.WriteLine("Input coordinates of first dot:");
// int Xa = Convert.ToInt32(Console.ReadLine());
// int Ya = Convert.ToInt32(Console.ReadLine());
// int Za = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinates of second dot:");
// int Xb = Convert.ToInt32(Console.ReadLine());
// int Yb = Convert.ToInt32(Console.ReadLine());
// int Zb = Convert.ToInt32(Console.ReadLine());
// Distance3d(Xa,Xb,Ya,Yb,Za,Zb);

// // /HomeWork 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// void Nsqrt(int num){
//     int count =1;
//     Console.Write(num + " -> " );
//     while(count<=num){
//         Console.Write(count*count*count + " ");
//         count++;
//     }
//     }

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// Nsqrt(N);





//Seminar 3
//1. 
// int QuarterFind (int X, int Y){
//     if (X > 0 && Y > 0)
//         return 1;
//     else if (X > 0 && Y < 0)
//         return 2;
//     else if (X < 0 && Y < 0)
//         return 3;
//     else if (X < 0 && Y > 0)
//         return 4;
//     else 
//         return 0;
// }
// Console.WriteLine("Введите коортидинату Х");
// int Xcoord = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите коортидинату Y");
// int Ycoord = Convert.ToInt32(Console.ReadLine());
// int result = QuarterFind(Xcoord,Ycoord);
// if (result == 0){
//     Console.WriteLine("Точка на осях. Введите кооректные данные");
// }
// else {
//     Console.WriteLine("Четверть " + result );
// }

//2.
// void Coordinat(int c) {
//     if (c==1){
//         Console.WriteLine("x > 0; y > 0");
//     }
//     else if (c==2){
//         Console.WriteLine("x < 0; y > 0");
//     }
//     else if (c==3){
//         Console.WriteLine("x < 0; y < 0");
//     }
//     else if (c==4){
//         Console.WriteLine("x > 0; y < 0");
//     }
//     else {
//         Console.WriteLine("Проверьте номер четверти");
//     }
// }
//  Console.WriteLine("Введите номер четверти:");
//  int q = Convert.ToInt32(Console.ReadLine());
//  Coordinat(q);

 
 //3.
// void Dist(int x1, int x2, int y1, int y2){
//     double dist1 =Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)); 
//    Console.WriteLine("Расстояние между двумя точками" + dist1);
// }

// Console.WriteLine("Input coordinates of first dot:");
// int Xa = Convert.ToInt32(Console.ReadLine());
// int Ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinates of second dot:");
// int Xb = Convert.ToInt32(Console.ReadLine());
// int Yb = Convert.ToInt32(Console.ReadLine());
// Dist(Xa,Xb,Ya, Yb);

//4.
// void Nsqrt(int num){
//     int count =1;
//     Console.Write(num + " -> " );
//     while(count<=num){
//         Console.Write(count*count + " ");
//         count++;
//     }
//     }

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// Nsqrt(N);






//HomeWork 2
// /HomeWork 2.1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// void ShowSecondNumber() {
//     int num = new Random().Next(100,1000);
//     int num1 =  num/100;
//     int num3 = num%10;
//     int num2 = (num - num1*100 - num3)/10;
//     Console.WriteLine(num + "->" + num2);
// }
// ShowSecondNumber();


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





