// ДЗ 1
// int [] array = new int[101]; 

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1,100); 
// }
// int count = array.Count(x => x >=20 && x <= 90);

// Console.WriteLine($"{count} элементов из массива лежат в отрезке [20;90]");

// ДЗ 2
// int [] array = new int[10]; 

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1,11); 
//     Console.Write(array[i]);
// }

// int evenCount = 0;

// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] % 2 == 0)
//     {
//         evenCount++;
//     }
// }
// Console.WriteLine("\nКоличество четных чисел: " + evenCount);

//ДЗ 3

int arrayLength = 5;
double[] array = new double[arrayLength];  
Random rnd = new Random();  

Console.WriteLine("Исходный массив: ");  
    for (int i = 1; i < array.Length; i++)  
    {  
        array[i] = rnd.NextDouble(); // Заполняем массив случайными дробными числами  
        Console.Write($"{array[i]} ");  
    }  

double min = array[0];  
for (int i = 1; i < array.Length; i++)  
{  
    if (array[i] < min)  
        min = array[i];  
}

double max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
}

double difference = max - min;

Console.WriteLine($"Разница между максимальным и минимальным элементом: {difference}");