//Задание 1
int n = Convert.ToInt32(Console.ReadLine());
int d = 0;
int i = 2;

while (i < n)
{
    if ((n % i) == 0)
    {
        d++; i++;
    }
    else
    {
        i++;
    }

}
if (d == 0)
{
    Console.WriteLine("Простое");
}
else
{
    Console.WriteLine("Не простое");
}


//Задание 2
//Аналогично примеру из методички, только у нас три цикла, один из которых вложенный.
//Следовательно сложность функции будет 0(N^3).


//Задание 3
//Без рекурсии
Console.Write("Введите конец диапазона от 1 до : ");
int end = int.Parse(Console.ReadLine());
int b = 1;
for (int a = 1; a <= end; a += b)
{
    Console.Write("{0} ", a);
    b = a - b;
}
Console.ReadKey();
return 0;
//С рекурсией: знаю, как находится число Фибоначчи, но не понимаю как выразить через метод

