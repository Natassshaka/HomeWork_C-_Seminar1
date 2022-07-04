
//HomeWork 5.
//1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i=0; i<array.Length; i++)
//         Console.Write(array[i]+ " ");
//     Console.WriteLine();
// }


// void CountEven(int [] array)
// {
//     int result =0;
//     int lenght = array.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         int x = array[i];
//         if ((x%2)==0) {
//             result=result +1;
//         }
//     }
//     Console.WriteLine(result);
// }

// Console.WriteLine("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Input start: ");
// // int start = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Input end: ");
// // int end = Convert.ToInt32(Console.ReadLine());
// int[] NewArray = CreateRandomArray(size); // создадли массив, который генерурует метод из рандомных чисел
// ShowArray(NewArray);
// CountEven(NewArray);


//2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] arrayA = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arrayA[i] = new Random().Next(min, max + 1);
//     }
//     return arrayA;
// }

// void ShowArray(int[] array)
// {
//     for (int i=0; i<array.Length; i++)
//     Console.Write(array[i]+ " ");
// }

// void SumEven(int[] array)
// {
//     int resultA = 0;
//     int lenght = array.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if (i%2 != 0)
//         {
//             resultA =  resultA + array[i];
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {resultA}");
// }

// Console.WriteLine("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input start: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input end: ");
// int end = Convert.ToInt32(Console.ReadLine());
// int[] NewArray = CreateRandomArray(size, start, end); // создадли массив, который генерурует метод из рандомных чисел
// ShowArray(NewArray);
// SumEven(NewArray);


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//  void Exstrem(int[] array){
//     int maxValue = NewArray.Max();
//     int minValue = NewArray.Min();
//     int result = NewArray.Max() - NewArray.Min();
//     Console.WriteLine();
//     Console.WriteLine($"Min: {maxValue}");
//     Console.WriteLine($"Max: {minValue}");
//     Console.WriteLine($"Разница: {result}");
//  }

// Exstrem(NewArray);


//Seminar 5.
//1.
//Функция, на задание массива (создали методы)
// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// //Выводим результат метода, который суммирует положительные/отрицательные числа массива
// void SumResult(int[] array)
// {
//     int resultA = 0;
//     int resultB = 0;
//     for (int i = 0; i < 12; i++)
//     {
//         if (array[i] < 0)
//         {
//             resultA += array[i];
//         }
//         else
//         {
//             resultB += array[i];
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Сумма отрицательных чисел {resultA}");
//     Console.WriteLine($"Сумма положительных чисел {resultB}");
// }

// void ShowArray(int[] array)
// {
//     for (int i=0; i<array.Length; i++)
//     Console.Write(array[i]+ " ");
// }

// //Создаем массива
// int [] MyArray  = CreateRandomArray(12,-9,9);
// ShowArray(MyArray);
// SumResult(MyArray);

// int [] CreateArray(int size)
// {
//     int[] array  = new int [size];
//     for(int i=0; i<size;i++){
//         Console.Write("Input " + i + " element: ");
//         array [i]=Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i=0; i<array.Length; i++)
//         Console.Write(array[i]+ " ");
//     Console.WriteLine();
// }

// Console.WriteLine();
// int[] myArray = CreateRandomArray(12,-9,9);
// ShowArray(myArray); 

//2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.[-4, -8, 8, 2] -> [4, 8, -8, -2]

// Console.WriteLine("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input start: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input end: ");
// int end = Convert.ToInt32(Console.ReadLine());
// int[] NewArray = CreateRandomArray(size, start, end); // создадли массив, который генерурует метод из рандомных чисел
// ShowArray(NewArray); 

// for (int i = 0; i < size; i++)
// {
//     NewArray[i] *= -1;
// }
// ShowArray(NewArray); 


//3.Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

// void MultMassive(int [] array)
// {
//     int result =1;
//     int lenght = array.Length / 2;
//     for (int i = 0; i < lenght; i++)
//     {
//         result = array[i] * array[array.Length-1-i];
//         Console.WriteLine(result);
//     }

// }

// Console.WriteLine("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input start: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input end: ");
// int end = Convert.ToInt32(Console.ReadLine());
// int[] NewArray = CreateRandomArray(size, start, end); // создадли массив, который генерурует метод из рандомных чисел
// ShowArray(NewArray); 
// MultMassive(NewArray); 








//HomeWork 4.

//3.Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array  = new int [size];
//     for(int i=0; i<size;i++){
//         array [i]=new Random().Next(min,max+1);
//     }
//     return array;
// int [] CreateArray(int size)
// {
//     int[] array  = new int [size];
//     for(int i=0; i<size;i++){
//         Console.Write("Input " + i + " element: ");
//         array [i]=Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i=0; i<array.Length; i++)
//     Console.Write(array[i]+ " ");
// }

// Console.WriteLine();
// int[] myArray = CreateRandomArray(8,1,100);
// ShowArray(myArray); 
// Console.Write("-> [");
// ShowArray(myArray); 
// Console.Write("]");


//2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// int Sum(int num)
// {
//     int result= (int)(num/Math.Pow(10,(int)Math.Log10(num)));
//     for (int i = 1; i <= num; i++)
//     {
//         result=result+num%10;
//         num = num /10;
//     }
//     return result;
// }
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Кол-во цифр:" + Sum(num));

// int SumNum(int num)
// {
//     int result = 0;
//     while (num>0){
//         result = result + num%10;
//         num = num / 10; 
//     }
//     return result;
// }
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сумма цифр:" + SumNum(num));

//1.Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 


//Seminar 4

// 1.
// int Sum (int А){
// int result = 0;
// if (А >= 1){
//     for(int i=1; i<=А; i++){
//         result += i;
//     }
//     return result;
// }
// else return 0;
// }

// Console.WriteLine("Input number:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сумма чисел: " + Sum(num));

//2. Программа, позволяет определить кол-во цифр число
// int CountNum(int num)
// {
//     int count = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Кол-во цифр:" + CountNum(num));


// int CountNum(int num)
// {
//     int count = 0;
//     while (num>0){
//         num = num / 10;
//         count++;
//     }
//     return count;
// }
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Кол-во цифр:" + CountNum(num));

// 3.   Найти произведение
// int Mult(int num){
//     int count = 1;
//     if (num < 1) return 0;
//     else {
//         for (int i=1; i<=num; i++)
//             count=count*i;
//         }
//         return count;
// }

// Console.WriteLine("Input number");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Mult:" + Mult(number));

// void Mult(int num){
//  int count =1;
//     if (num < 1){
//         Console.WriteLine(" Введено плохое число");
//     } 
//     else {
//         for (int i=1; i<=num; i++)
//             count*=i;
//         }
//         Console.WriteLine("Произведение " + count);
//         ;
// }
// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// Mult(N);

//4.
// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array  = new int [size];
//     for(int i=0; i<size;i++){
//         array [i]=new Random().Next(min,max+1);
//     }
//     return array;
// }
// int [] CreateArray(int size)
// {
//     int[] array  = new int [size];
//     for(int i=0; i<size;i++){
//         Console.Write("Input " + i + " element: ");
//         array [i]=Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i=0; i<array.Length; i++)
//     Console.Write(array[i]+ " ");
// }

// Console.WriteLine();

// int[] myArray = CreateArray(8);
// ShowArray(myArray);

//HomeWork 3
// /HomeWork 19: *Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.  

// int Polimdrom(int n) {
// int reverse = 0;
// while (n!=0){
//     reverse = reverse *10;
//     reverse = reverse + n %10;
//     n=n/10;
//     }
// return reverse;    
// }

// Console.WriteLine("Input number:");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = Polimdrom(num);
// int l = num.ToString().Length;
// if (l!=5){
//     Console.WriteLine("Введите 5-ое число");
// }
// else if (num== result){
//      Console.WriteLine("Введенное число является палиндромом");
// }
// else {
//         Console.WriteLine("Введенное число НЕ является палиндромом");
//     }


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


//Seminar 6.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] arrayA = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arrayA[i] = new Random().Next(min, max + 1);
//     }
//     return arrayA;
// }

// void ShowArray(int[] array)
// {
//     for (int i=0; i<array.Length; i++)
//     Console.Write(array[i]+ " ");
// }


// Console.WriteLine("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input start: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input end: ");
// int end = Convert.ToInt32(Console.ReadLine());
// int[] NewArray = CreateRandomArray(size, start, end); // создадли массив, который генерурует метод из рандомных чисел
// ShowArray(NewArray);
// Console.WriteLine();
// int[] ReversArray = new int[size];
//      for(int i=0, j=size-1; i<size; i++, j--){
//       ReversArray[i]=NewArray[j];
// }
// ShowArray(ReversArray);

// 2. Возможен ли треугольник
// bool VarficationTriangl (int A, int B, int C){
//     if (A<B+C && B<A+C && C<A+B){
//         return true;
//     }
//     else{
//         return false;
//     }
// }
// Console.WriteLine("Input 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input 2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input 3: ");
// int c = Convert.ToInt32(Console.ReadLine());
// if (VarficationTriangl(a,b,c))
// {
//     Console.WriteLine("Треугольник с тами сторонами существует");
// }
// else{
//     Console.WriteLine("Треугольник с тами сторонами НЕ существует");
// }

//HomeWork 6. 
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// int [] CreateArray(int size)
// {
//     int[] array  = new int [size];
//     Console.WriteLine("Укажите числа через Enter: ");
//     for(int i=0; i<size;i++){
//         // Console.Write("Укажите числа через Enter: ");
//         array [i]=Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i=0; i<array.Length; i++)
//         Console.Write(array[i]+ " ");
//     Console.WriteLine();
// }

// Console.WriteLine("Укажите кол-во чисел: ");
// int size = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Input start: ");
// // int start = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Input end: ");
// // int end = Convert.ToInt32(Console.ReadLine());
// int[] NewArray = CreateArray(size); // создадли массив, который генерурует метод из рандомных чисел
// ShowArray(NewArray);

// void ShowCount(int[] array)
// {
//     int count = 0;
//     for (int i=0; i<array.Length; i++){ 
//         if (array[i]>0){
//             count ++;
//         }
//     }
// Console.Write("Кол-во положительных элементов {count}");
// }

// ShowCount(NewArray);

// void CountPlus(int [] array)
// {
//     int count =0;
//     int lenght = array.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         int x = array[i];
//         if (x>0) {
//             count=count +1;
//         }
//     }
//     Console.WriteLine("Кол-во положительных элементов: " + count);
// }
// CountPlus(NewArray);

//Второй вариант решения, честно подсмотренный в Internet
// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
 
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }
 
// Console.WriteLine($"Кол-во элементов > 0: {count}");
//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Write("Введите число ");
int value = Convert.ToInt32(Console.ReadLine());;
string binary = Convert.ToString(value, 2);
Console.WriteLine(binary);