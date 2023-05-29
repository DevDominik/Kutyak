using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Kutyak;
string adatforras = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\Datas\\";

List<Kutya> kutyak = File.ReadAllLines($"{adatforras}Kutyak.csv").Skip(1).Select(x => new Kutya(x)).ToList();
List<string> nevek = new List<string>();
List<List<string>> fajtak = new List<List<string>>();
StreamReader sr = new StreamReader($"{adatforras}KutyaNevek.csv");
sr.ReadLine();
while (!sr.EndOfStream)
{
    nevek.Add(sr.ReadLine().Split(';')[1]);
}
sr.Close();
sr = new StreamReader($"{adatforras}KutyaFajtak.csv");
sr.ReadLine();
while (!sr.EndOfStream)
{
    fajtak.Add(sr.ReadLine().Split(';').ToList());
}
sr.Close();
Console.WriteLine($"Kutyák neveinek száma: {nevek.Count()}");
Console.WriteLine($"Kutyák átlag életkora: {Math.Round(kutyak.Average(x => x.Eletkor), 2)}");
Kutya keresett = kutyak.OrderByDescending(x => x.Eletkor).First();
Console.WriteLine($"Legidősebb kutya neve és fajtája: {nevek[keresett.NevId - 1]}, {fajtak[keresett.FajtaId - 1][1]} ({fajtak[keresett.FajtaId - 1][2]})");
Console.WriteLine($"Kutyák száma az orvosnál 2018.01.10-én: {kutyak.Count(x => x.UtolsoEllenorzes == "2018.01.10")}");
Console.WriteLine($"Legjobban leterhelt nap: ");
StreamWriter sw = new StreamWriter($"{adatforras}statisztika.txt");
foreach (Kutya item in kutyak)
{
    sw.WriteLine($"{nevek[item.NevId - 1]};{kutyak.GroupBy(y => y.NevId).Count()}");
}
sw.Close();