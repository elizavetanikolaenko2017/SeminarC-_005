/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[]array = new double[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1,100);
}
System.Console.WriteLine("[" + string.Join(",", array) + "]");
double max= 0;
double min = 0;
double difference =0;
for (int i = 1; i < array.Length; i++)
if (array[i]>max)
{
   array[i]=max; 
}
else
{
    difference= max - min;
}
System.Console.WriteLine("Разница между максимальным и минимальным элементами данного массива составляет: " + difference);
