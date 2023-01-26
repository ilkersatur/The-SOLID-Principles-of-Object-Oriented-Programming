using LSV;

PersonelIslemleri personelIslemleri = new PersonelIslemleri();

Memur memur = new Memur() { Maas=14000};
Mudur mudur = new Mudur() { Maas = 30000, Prim = 10000 };

Console.WriteLine(personelIslemleri.MaasGoster(memur));
Console.WriteLine(personelIslemleri.MaasGoster(mudur));