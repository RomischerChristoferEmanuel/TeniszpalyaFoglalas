using TeniszpalyaFoglalas;

List<Foglalas>adatok=new List<Foglalas>();
Console.WriteLine("Napi pályafoglalások:");
foreach(string sor in File.ReadAllLines("foglalasok.txt"))
{
    adatok.Add(new Foglalas(sor));
    
}
foreach(Foglalas aktualis in adatok)
{
    Console.WriteLine(aktualis);
}
Console.WriteLine("\nStatisztika:");
int telj=adatok.Sum(x=>x.FizetendoDij());
Console.WriteLine($"Teniszcentrum teljes napi bevétele: {telj} Ft");
Foglalas leg = adatok.MaxBy(x=>x.FoglaltOrak );
Console.WriteLine($"Legtöbb órát foglaló játékos: {leg.JatekosNev} ({leg.FoglaltOrak} óra)");