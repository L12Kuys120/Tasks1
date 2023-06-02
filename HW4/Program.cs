/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write("Введите количество элементов массива   "); 
int Elements = int.Parse(Console.ReadLine()); 
int[] numbers = new int[Elements];                  //объявляется массив "numbers" с длиной = "Elements"

for(int i = 0; i < Elements; i++)
    {
    Console.WriteLine($"Введите элемент массива {i}  "); 
    numbers[i] = int.Parse(Console.ReadLine());         //ввод элементов массива

    }
    Console.WriteLine("Вывод массива"); 
for(int i = 0; i < Elements; i++)
    {
    Console.WriteLine($"Элемент {i}  " +numbers[i]);         //вывод элементов массива
    }
int max = numbers[0];
int count = 1;

while(count < Elements)
{
    if(max < numbers[count])
    {
        max = numbers[count];
    }

count++;
}
Console.WriteLine("max=  " + max);