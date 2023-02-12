// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели, для проверки выходного: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
    {
    Console.WriteLine("Нет");
}
else if (a == 2)
    {
    Console.WriteLine("Нет");
}
else if (a == 3)
    {
    Console.WriteLine("Нет");
}
else if (a == 4)
    {
    Console.WriteLine("Нет");
}
else if (a == 5)
    {
    Console.WriteLine("Нет");
}
else if (a == 6)
    {
    Console.WriteLine("Да");
}
else if (a == 7)
    {
    Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("такого дня не существует");
}