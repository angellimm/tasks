// Задача 1: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


string Len(int start, int stop)
{
    if(start == stop) return Convert.ToString(stop);
    return start + " " + Len(start +1, stop);
}

Console.WriteLine("введите m ");
Console.WriteLine("введите n ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Len(n,m));



// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.


int Akkerman(int first, int second)
{

    if (first == 0) return second + 1;
    else if (second == 0) return Akkerman(first - 1, 1);
    else return Akkerman(first - 1, Akkerman(first, second - 1));

}

Console.WriteLine("введите m ");
Console.WriteLine("введите n ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(n, m));


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная 
// с конца. Использовать рекурсию, не использовать циклы.

void Print(int [] num, int n) 
    { 
      if (n > 0) 
      { 
      	Console.Write(num[n] + " "); 
      	Print(num, n - 1); 
      } 
      else Console.WriteLine(num[0]); 
    } 

int[] arr = [4,36,88,12,56];
Print(arr, arr.Length - 1);

