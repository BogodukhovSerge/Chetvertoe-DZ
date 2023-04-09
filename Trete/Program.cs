// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Bass(string sms)
{
    System.Console.WriteLine(sms);
    string readImput = System.Console.ReadLine();
    int result = int.Parse(readImput);
    return result; 
}

int[] GeneratorArray(int Lenght, int minValui, int MaxxValua)
{
    int[] array = new int[Lenght];
    Random random = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        array[i] = random.Next(minValui, maxValue + 1);
    }
    return array;

}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Lenght; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}

int Lenght = Bass("Dlena maseva: ");
int min = Bass("Nachalnoe znach, dlya leapazona sluchayn chisel: ");
int max = Bass("Konechnoe znach, dlya leapazona sluchayn chisel: ");
int [] array = GeneratorArray(Lenght, min, max);
PrintArray(array);
