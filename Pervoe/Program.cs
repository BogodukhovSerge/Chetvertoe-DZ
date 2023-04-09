// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Bass(string sms)
{
    System.Console.WriteLine(sms);
    string readImput = System.Console.ReadLine();
    int result = int.Parse(readImput);
    return result; 
}

int Vozvedenie(int znachA, int exponentB)
{
    int znach = 1;
    for (int i = 0; i < exponentB; i++)
    {
        znach *= znachA;
    }
    return znach;

}

int znachA = Bass("vvedite osnovanie: ");
int exponentB = Bass("Vvedite Pokazatel: ");
System.Console.WriteLine($"Cheslo {znachA} v stepeni {exponentB} ravno {Vozvedenie(znachA , exponentB)}");