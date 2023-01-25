
/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */ 

int GetNumbers(string messange)
{
    Console.Write(messange);
    int result=0;
    while(true)
    {
        if(int.TryParse(Console.ReadLine(),out result)) break;
        else Console.Write("Введите число, чтобы продолжить -> ");
    }
    return result;
}
void ExponentiationNumber(int a , int b)
{ 
   Console.Write($"Ввозведение числа {a} в степень {b} -> {Math.Pow(a,b)}");
}
ExponentiationNumber(GetNumbers("Введите число-> "), GetNumbers("Введите степень ->"));