using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Kutyak;
string adatforras = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\Datas\\";

List<Kutya> kutyak = File.ReadAllLines($"{adatforras}Kutyak.csv").Skip(1).Select(x => new Kutya(x)).ToList();
List<List<string>> nevek = new List<List<string>>();
List<List<string>> fajtak = new List<List<string>>();
StreamReader sr = new StreamReader($"{adatforras}KutyaNevek.csv");
sr.ReadLine();
while (!sr.EndOfStream)
{
    nevek.Add(sr.ReadLine().Split(';').ToList());
}
sr.Close();
sr = new StreamReader($"{adatforras}KutyaFajtak.csv");
sr.ReadLine();
while (!sr.EndOfStream)
{
    fajtak.Add(sr.ReadLine().Split(';').ToList());
}
sr.Close();
