// создать программу при помощи рекурсии которая на вход принимает в себя число M и показывает все числа на убывание от M до 1.
int m; 
int n = 1;
Console.Write($"Введите М: ");
int.TryParse(Console.ReadLine(), out m);


OutNumbers(m, n);

void OutNumbers(int m, int n)
{
    if (m == n)
        Console.Write($"{m} ");
    else
    {
        Console.Write($"{m}, ");
        OutNumbers(m - 1, n);
    }
}