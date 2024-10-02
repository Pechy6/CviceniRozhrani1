// See https://aka.ms/new-console-template for more information

using JednoduchyPriklad;

Console.WriteLine("Welcome to CviceniRozhrani");
Zakaznik zakaznik = new Zakaznik(1, "Patrik", "Pech");
Adresa adresa = new Adresa("Stritez", 159, 1, "Jihlava", 58811);
Produkt produkt = new Produkt("Airpods Pro", "Airpods Pro 2 generace nejlepsich sluchatek na svete", 249);
Objednavka objednavka = new Objednavka(1, produkt, zakaznik, adresa);
Gateway brana = new Gateway();
brana.ProcessOrder(objednavka);

// Programu potrebuji dodelat Arrays[] ktere potrebuji propojit pres rozhrani aby nezasahovala do  