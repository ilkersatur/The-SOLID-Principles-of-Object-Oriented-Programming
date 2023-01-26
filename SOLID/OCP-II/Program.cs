using OCP_II;

DosyaIslemleri dosyaIslemleri = new DosyaIslemleri();

TextDosya txt = new TextDosya();
JsonDosya json = new JsonDosya();
XmlDosya xml = new XmlDosya();

Console.WriteLine(dosyaIslemleri.Oku(txt));
Console.WriteLine(dosyaIslemleri.Oku(json));
Console.WriteLine(dosyaIslemleri.Oku(xml));
