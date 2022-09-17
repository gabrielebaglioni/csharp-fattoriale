Console.WriteLine("scrivi un numero");
long N = Convert.ToInt64(Console.ReadLine());

long fattoriale(long N)
{
    if( N<= 0)
    {
        return 1;
    }
    {
        return N * fattoriale(N - 1);
    }

}
Console.WriteLine($"il fattoriale è {fattoriale(N)}");

