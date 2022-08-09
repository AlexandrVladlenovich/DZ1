 int a = 1;
 int c = 2;
 
Console.WriteLine("Введите число n");
String ns = Console.ReadLine() ??"";
int n;
if (int.TryParse(ns, out n))
for (int i = a; i <= n; i++)      // идет от а до n с шагом 1
    if (i % c == 0)                // каждое чиcло делим на с , берем остаток от деления и сравниваем его с нулем
    Console.Write(i + ";");   // если равно нулю выводим
