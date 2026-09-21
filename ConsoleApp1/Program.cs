Console.WriteLine("Hello, World!");
//tablica 6 wartości losowych
//funkcja zwraca tablice przekazujemy do niej liczbe elementow

int[] WylosujTablice(int LiczbaElementów)
{
    int[] tablicaWylosowana = new int[LiczbaElementów];
    for(int i = 0; i < tablicaWylosowana.Length; i++)
    {
        Random random = new Random();
        tablicaWylosowana[i] = random.Next(1, 100);
    }
    return tablicaWylosowana;
}
void wypiszTablice(int[] tablicaDoWypisywania)
{
    Console.WriteLine("tablica");
    for (int i = 0; i < tablicaDoWypisywania.Length; i++)
    {
        Console.Write(tablicaDoWypisywania[i] + ", ");
    }
}

int[] tablicaTestowa = WylosujTablice(10);
wypiszTablice(tablicaTestowa);