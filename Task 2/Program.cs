Console.WriteLine("Введите первое число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чило b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число c");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b) max = b;
if (max < c) max = c;
System.Console.WriteLine("Максимальное из этих чисел = " + max);



