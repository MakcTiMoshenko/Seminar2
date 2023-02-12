// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) {
    System.Console.WriteLine("Введено не трехзначное число, третьей цифры нет");
}
int[] arr = number.ToString().ToCharArray().Select(x => x - '0').ToArray();

System.Console.WriteLine( arr[2] );