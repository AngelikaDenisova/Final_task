Console.WriteLine("Введите массив через пробел: ");
string[] array = Console.ReadLine()!.Split(' ');
string[] result = new string[array.Length];

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)  
    {
      Console.Write(result[i] = array[i] + " ");   
    }  
    }
   