//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.
int ReadInt(string str){
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");

void PrintNum(int M,int N){
    if (M>N) return;
    Console.Write(M+" ");
    PrintNum(++M,N);
}
PrintNum(M,N);