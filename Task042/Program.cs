// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();

 int[] arrDecimal = new int[str.Length];

for (int i = 0; i < str.Length; i++)
{
    
    arrDecimal[i] = Convert.ToInt32(str[i].ToString());
    }
    //Console.WriteLine(string.Join("," ,arrDecimal));

int size = arrDecimal.Length*4;





int[]binArray = new int[size];
void ConversionToBinarySistem(int number)
{

 int remaine = 0;
   for (int i = 0; i < size; i++)
   {

    remaine = number%2;
    binArray[i] = remaine;
    number = number/2;
    }

    
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        
       array[i] = binArray[size - 1-i];
     

    } 
     
    Console.WriteLine(string.Join("," ,array));
}
  ConversionToBinarySistem(number);




 