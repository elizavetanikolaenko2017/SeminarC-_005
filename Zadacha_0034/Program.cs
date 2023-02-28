/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] array = new int[4];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100,1000);
}
System.Console.WriteLine("[" + string.Join(",", array) + "]");
int Evennumber=0;

for ( Evennumber= 0; Evennumber< array.Length; Evennumber++)
{
    if(Evennumber%2==0)
    {
      Evennumber++;
  
    }
}
System.Console.WriteLine("Количество чётных чисел в массиве: " + Evennumber);

