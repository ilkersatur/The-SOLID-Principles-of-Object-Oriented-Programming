using OCP;

DosyaIslemleri dosya = new DosyaIslemleri();

TextDosya text = new TextDosya();

XmlDosya xml = new XmlDosya();

JsonDosya json = new JsonDosya();

Console.WriteLine(dosya.Oku(text));
Console.WriteLine(dosya.Oku(json));
Console.WriteLine(dosya.Oku(xml));