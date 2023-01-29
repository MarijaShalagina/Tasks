// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа 456=6
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 || num > 999){
    Console.WriteLine("Введено неправильное число");
    return;
}
int otvet = num % 10;
Console.WriteLine($"3 цифра: {otvet}");
