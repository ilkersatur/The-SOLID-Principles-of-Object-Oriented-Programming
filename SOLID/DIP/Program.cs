using DIP;

//DatabaseManager manager = new DatabaseManager(new SqlDB());
DatabaseManager manager = new DatabaseManager(new OracleDB());

foreach (var item in manager.VerileriGetir())
{
    Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.PersonelID);
}

Console.WriteLine("---------------------------------");

DatabaseManager manager2 = new DatabaseManager();

manager2.VeriTabani = new SqlDB();
foreach (var item in manager2.VerileriGetir())
{
    Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.PersonelID);
}

Console.WriteLine("-----------");

DatabaseManager manager3 = new DatabaseManager();

manager3.VeriTabani = new OracleDB();
foreach (var item in manager3.VerileriGetir())
{
    Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.PersonelID);
}

