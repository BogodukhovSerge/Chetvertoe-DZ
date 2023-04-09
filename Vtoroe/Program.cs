// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Bass(string sms)
{
    System.Console.WriteLine(sms);
    string readImput = System.Console.ReadLine();
    int result = int.Parse(readImput);
    return result; 
}    

int SumAZnach(int Num)
{
    int result = 0;
    while (Num > 0)
    {
        result += Num % 10;
        Num = Num / 10;
    }
    return result;

}
int Num = Bass("Vvedite cheslo: ");
System.Console.WriteLine($"Summa vseh chisel v znach {Num} = {SumAZnach(Num)}");
