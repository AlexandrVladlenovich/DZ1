Console.WriteLine("Введите number_A");
string number_As = Console.ReadLine() ??"";
int number_Ai;
Console.WriteLine("Введите number_B");
String number_Bs = Console.ReadLine() ??"";
int number_Bi;
Console.WriteLine("Введите number_C");
String number_Cs = Console.ReadLine() ??"";
int number_Ci;

int.TryParse(number_As, out number_Ai);
int.TryParse(number_Bs, out number_Bi);
int.TryParse(number_Cs, out number_Ci);

int max = number_Ai;
if (number_Bi > max) max = number_Bi;
if (number_Ci > max) max = number_Ci;

Console.Write("максимальное число= ");
Console.WriteLine(max);