//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
var rand = new Random();
int ReadInt(string str){
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
int size = ReadInt("Введите размер массива: ");
int[] massive = new int[size];
for (int i =0;i<size;i++){
    massive[i] = rand.Next(10);
    Console.Write(massive[i] + " ");
}
Console.WriteLine();
void PrintMas(int[] massive,int size){
    if (size<0) return;
    Console.Write(massive[size-1]+ " ");
    PrintMas(massive,--size);
}
PrintMas(massive,size);