// Задача 43: Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = ratio2Line1 * x + ratio1Line1, y = ratio2Line2 * x + ratio1Line2; 
// значения ratio1Line1, ratio2Line1, ratio1Line2 и ratio2Line2 задаются пользователем.

// ratio1Line1 = 2, ratio2Line1 = 5, ratio1Line2 = 4, ratio2Line2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите коэффициент 1 для первой прямой: ");
double ratio1Line1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите коэффициент 2 для первой прямой: ");
double ratio2Line1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите коэффициент 1 для второй прямой: ");
double ratio1Line2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите коэффициент 2 для второй прямой: ");
double ratio2Line2 = Convert.ToDouble(Console.ReadLine());
double x = 0;
double y = 0;

if (ratio1Line1 == ratio1Line2 && ratio2Line1 == ratio2Line2) 
{
    Console.WriteLine("Прямые совпадают");
}
        

else
{
    x = (ratio1Line2 - ratio1Line1) / (ratio2Line1 - ratio2Line2);
    y = ratio2Line1 * x + ratio1Line1;


}
Console.WriteLine($"Точка пересечения прямых: ({Math.Round(x,3)} ; {Math.Round(y,3)})");

