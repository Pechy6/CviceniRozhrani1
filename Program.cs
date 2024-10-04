//See https://aka.ms/new-console-template for more information

using JednoduchyPriklad;

Console.WriteLine("Welcome to CviceniRozhrani");
Zakaznik zakaznik = new Zakaznik(1, "Tomáš", "Marný");
Adresa adresa = new Adresa("Ve Svahu", 10, 2, "Praha", 10000);
Produkt produkt = new Produkt("Body pro ITnetwork.cz",
    "Body pro zpřístupnění prémiového obsahu a dosažení vašeho vysněného zaměstnání v IT.", 239);
Objednavka objednavka = new Objednavka(1, produkt, zakaznik, adresa, adresa);
Gateway brana = new Gateway();
brana.ProcessOrder(objednavka);

// Programu potrebuji dodelat Arrays[] ktere potrebuji propojit pres rozhrani aby nezasahovala do  