﻿//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int ReadInt(string str){
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");
int Akkerman(int m , int n ){
    if (m==0) return (n+1);
    else if  (n==0) return Akkerman(m-1,1);
    else return Akkerman(m-1,Akkerman(m,n-1));;
}
Console.WriteLine(Akkerman(m,n));
