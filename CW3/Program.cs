/*3. Напишите программу, которая будет выдавать название 
дня недели по заданному номеру.

3 -> Среда
5 ->  Пятница*/

Console.Write("Введите номер: ");
int number = int.Parse(Console.ReadLine());

if(number == 3) 
{
    Console.WriteLine("Среда");
}if(number == 5)
{
    Console.WriteLine("Пятница");
}   else
    { 
   Console.WriteLine("не знаю");
    }

