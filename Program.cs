using Gra_w_kosci_2026_konsola;

Console.WriteLine("Wprowadz liczbe od 1 do 6");
int WprowadzLiczbe = Int32.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Obiekt pierwszy");
Kosc Kosc1 = new Kosc(WprowadzLiczbe);
Console.WriteLine("Liczba instancji: " + Kosc.LiczbaInstancji);
Console.WriteLine("Liczba oczek: " + Kosc1.LiczbaOczek);
Console.WriteLine("Liczba oczek slownie: " + Kosc1.ZwrocWyrzuconaWartosc());
Console.WriteLine("Nazwa pliku: " + Kosc1.NazwyPlikow[Kosc1.IdentyfikatorPlikuGraficznego]);

Console.WriteLine();

Console.WriteLine("Obiekt drugi");
Kosc Kosc2 = new Kosc();
Console.WriteLine("Liczba instancji: " + Kosc.LiczbaInstancji);
Console.WriteLine("Liczba oczek: " + Kosc2.LiczbaOczek);
Console.WriteLine("Liczba oczek slownie: " + Kosc2.ZwrocWyrzuconaWartosc());
Console.WriteLine("Nazwa pliku: " + Kosc2.NazwyPlikow[Kosc2.IdentyfikatorPlikuGraficznego]);