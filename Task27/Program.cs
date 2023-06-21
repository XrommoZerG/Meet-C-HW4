// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Vod(string masseg)
{

    Console.WriteLine(masseg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int SumC(int a)
{

    int result = 0;

    while (a > 0)
    {
        result = result + (a % 10);
        a /= 10;
    }

    return result;
}


int number = Vod("Введите цифру");
if (number>0)
{
    Console.WriteLine("Сума цифр = " + SumC(number));

}
else
{
        Console.WriteLine("Вы ввели цифру меньше 1");

}



