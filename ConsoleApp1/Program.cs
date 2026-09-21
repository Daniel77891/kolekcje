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
int[] wczytajLiczbyDoTablicy(int ileLiczb)
{
    int[] tablicaZKlawiatury = new int[ileLiczb];
    for(int i = 0; i < ileLiczb; i++)
    {
        Console.WriteLine("podaj liczbe");
        tablicaZKlawiatury[i] = int.Parse(Console.ReadLine());
    }
    return tablicaZKlawiatury;
}
int[] tablicaWczytana = wczytajLiczbyDoTablicy(6);
wypiszTablice(tablicaWczytana);

List<int>wylosowanieliczbbezpowtorzen(int ileLiczb)
{
    List<int> liczbaLiczbLosowych = new List<int>();
    //w listach mozna zmienac rozmiar
    //w trakcie działań programu
    Random ranndom = new Random();
    for(int i =0; i < ileLiczb; i++)
    {
        int liczba = ranndom.Next(1, 10);
            while (liczbaLiczbLosowych.Contains(liczba)){
        liczba = ranndom.Next(1, 10);
    }
        liczbaLiczbLosowych.Add(liczba);
    }
    return liczbaLiczbLosowych;
}
void wypiszListę(List<int> listaLiczb)
{
    Console.WriteLine();
    Console.WriteLine("lista");
    for(int i = 0; i < listaLiczb.Count; i++)
    {
        Console.Write(listaLiczb[i] + ", ");
    }
}
List<int> wylosowane = wylosowanieliczbbezpowtorzen(7);
wypiszListę(wylosowane);



HashSet<int> wylosujLiczbyBezPowtorzenDoZbioru(int ileLiczb)
{
    HashSet<int> zbiorLosowych = new HashSet<int>();
    Random random = new Random();
    while (zbiorLosowych.Count<ileLiczb)
    {
        zbiorLosowych.Add(random.Next(1, 10));
    }
    return zbiorLosowych;
}
void wypiszZbior(HashSet<int> zbiorLiczb)
{
    Console.WriteLine();
    Console.WriteLine("Zbiór:");
    Console.WriteLine();
    Console.WriteLine("ZBiór:");
    foreach(int element in zbiorLiczb)
    {
        Console.WriteLine(element);
    }

}
HashSet<int> wylosowanyZbior = wylosowanieliczbbezpowtorzen(7);
wypiszZbior(wylosowanyZbior);
