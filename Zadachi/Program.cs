/* Дано число n. Получите число, записанное в обратном порядке.
345 >> 543
81 >> 18 */

Console.WriteLine (" Задача 1");

int n = 45691;
Console.Write (n);
Console.Write ( " ");
Recursoion ( n);

void Recursoion (int number,int result = 0)
{
    if (number ==0) 
   {
        Console.WriteLine (result);
    return;
   }
   result = result*10 + number%10;
   number /= 10;
   Recursoion ( number,result);
   
}

// Задача 2.Дана монотонная последовательность, в которой каждое натуральное 
//число n встречается ровно n раз: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... 
//Дано число m. Выведите первые m членов этой последовательности. m = 5 >> 1, 2, 2, 3, 3

Console.WriteLine (" Задача 2");

int q = 5;

Zadacha2(q);

void Zadacha2 (int number/*наше число */,int currentNumber = 1 /* текущее число*/, int itog =0/*сколько вывели*/)
{
    if ( number ==0) return;
    number--;
    itog++;

    if (itog>currentNumber)
    {
        currentNumber++;
        itog = 1;
    }
    Console.Write(currentNumber);
    Zadacha2 ( number, currentNumber, itog);
}

//Задача 3 : Дано натуральное число n > 1. Вывести все простые множители данного числа.

Console.WriteLine (" ");
Console.WriteLine (" Задача 3");

int a = 90;
void Zadacha3 (int chislo, int delitel = 2)
{
    if (chislo ==1) return;

   if (chislo% delitel ==0)
  {
     chislo = chislo / delitel;
     
     Console.Write ( delitel + " ");
  }
  else 
  {
      delitel++;
         
  }
  Zadacha3(chislo,delitel);
}
 Zadacha3(a);


