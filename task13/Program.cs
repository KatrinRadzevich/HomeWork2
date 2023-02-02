// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Данная программа работает с целыми числами,состоящими из от 2 до 7 цифр и выводит третью из них");
//т к не придумала способа,кроме ручного прописывать условия.но условия задачи по примеру перевыполнены на 2 символа
int a = new Random().Next(10, 1000001);
if (a >= 10 && a < 100)
{
    Console.WriteLine($"{a} -> третьей цифры нет");
}
if (a >= 100 && a < 1000)
{
    int lastnum = a % 10;
    Console.WriteLine($"{a} -> {lastnum}");
}
if (a >= 1000 && a < 10000)
{
    int last2nums = a % 100;
    int thirdnum = last2nums / 10;
    Console.WriteLine($"{a} -> {thirdnum}");
}
if (a >= 10000 && a < 100000)
{
    int last3nums = a % 1000;
    int thirdnum = last3nums / 100;
    Console.WriteLine($"{a} -> {thirdnum}");
}
if (a >= 100000 && a < 1000000)
{
    int last4nums = a % 10000;
    int thirdnum = last4nums / 1000;
    Console.WriteLine($"{a} -> {thirdnum}");
}