//Задача 13: Напишите программу, которая с помощью деления выводит 
//третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//3267432979 -> 6
 
Console.Write("Введи число: "); 
 
int number = Math.Abs(Convert.ToInt32(Console.ReadLine())); 
 
if (number < 100) 
{ 
  Console.WriteLine("третьей цифры нет");  
} 
else 
{ 
  int digit = number % 10;
  while (number > 100) {
    digit = number % 10;
    number = number / 10;
  }
  Console.WriteLine(digit);
}
