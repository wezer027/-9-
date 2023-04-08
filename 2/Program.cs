int M, N;
Console.Write("Введите M: ");
int.TryParse(Console.ReadLine()!, out M);
Console.Write("Введите N = ");
int.TryParse(Console.ReadLine()!, out N);
Console.WriteLine($"{M} -> {N} = {SumNumbers(M, N)}");
Console.ReadLine();
 
static int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
    else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
    else if (M == N) return M;                       // Если M=N
    else if (M < N) return N + SumNumbers(M, N - 1); // Если M<N
    else return N + SumNumbers(M, N + 1);            // Если M>N
}