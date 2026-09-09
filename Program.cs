using Gra_w_kosci_2026_konsola;
Console.WriteLine("Wprowadz liczbe od 1 do 6");
int WprowadzLiczbe = Int32.Parse(Console.ReadLine());

Kosc Kosc1 = new Kosc(WprowadzLiczbe);
Console.WriteLine("liczba instancji: " + Kosc.LiczbaInstancji);
Console.WriteLine("liczba oczek: " + Kosc1.LiczbaOczek);
Console.WriteLine("nazwa pliku: " + Kosc1.NazwyPlikow[Kosc1.IdentyfikatorPlikuGraficznego]);

Console.WriteLine();

Kosc Kosc2 = new Kosc();
Console.WriteLine("liczba instancji: " + Kosc.LiczbaInstancji);
Console.WriteLine("liczba oczek: " + Kosc2.LiczbaOczek);
Console.WriteLine("nazwa pliku: " + Kosc2.NazwyPlikow[Kosc2.IdentyfikatorPlikuGraficznego]);