// See https://aka.ms/new-console-template for more information

using JednoduchyPriklad;

Console.WriteLine("Welcome to CviceniRozhrani");
Zakaznik zakaznik = new Zakaznik(1,"Patrik", "Pech");
Adresa adresa = new Adresa("Stritez", 159, 1, "Jihlava", 58811);
Produkt produkt = new Produkt("Airpods Pro", "Airpods Pro 2 generace nejlepsich sluchatek na svete");
Objednavka objednavka = new Objednavka(1, produkt, zakaznik);
Console.WriteLine(objednavka.FirstName);