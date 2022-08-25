// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("input numbers M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int[] arrayM = new int[numberM];

    for (int i = 0; i < numberM; i++)
    {
        arrayM[i] = Convert.ToInt32(Console.ReadLine());
    }

int countNegativeNumber = 0;




 for (int i = 0; i < numberM; i++)
 {
    if (arrayM[i] < 0)
    {
        countNegativeNumber = countNegativeNumber + 1;       
    }

 }  
System.Console.WriteLine($"{string.Join(",", arrayM)} => {countNegativeNumber}");