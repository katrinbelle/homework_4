/*  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
 int GetNumber(string messenge)
 {
    Console.Write(messenge);
    int result=0;
    while(true){
    if(int.TryParse(Console.ReadLine(),out result)&& result>0 && result < 10000) break;
    else Console.Write("Ввели  слишком большое число или отрицательное, введите число ,чтобы продолжить ->");
    }
    return result;
 }

void OutSumm(int value)
{ int summNumbers=0;

   if(value<100 && value> 0) summNumbers=value/10+value%10;
   else if(value>=100 && value<=999) summNumbers=value/100+value/10%10+value%10;
    else if(value>=1000 && value<=9999) summNumbers=value/1000+value/100%10+value/10%10+value%10;
 
    Console.Write($"Сумма каждой цифры от числа {value} равна {summNumbers}");
}
OutSumm(GetNumber("Введите число, чтобы подсчитать сумму ->"));





      

  