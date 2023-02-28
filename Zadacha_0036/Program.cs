/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = new int[4];// Создала массив со случайными цифрами, шаг 1, с функцией
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(10,100);
}
Console.WriteLine("[" + string.Join(",", array) + "]");

int Oddnumber=0;
int Evennumber=0;
int OddnumberSum=0;
for (int i = 0; i <array.Length; i++)
{
   if (Evennumber%2==0)
   {
    Evennumber++;
   }
   else
   {
    OddnumberSum+=Oddnumber;
   } 
}
System.Console.WriteLine($"Сумма нечётных чисел в данном массиве: {OddnumberSum}");
