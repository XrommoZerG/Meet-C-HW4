// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



int Vod(string masseg)
{

    Console.WriteLine(masseg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int Randoms()
{
    int a = Random.Shared.Next(100);

    return a;
}


int[] mass = new int[8];


Console.WriteLine("Выберите способ заполнения масива 1-Вручную 2-автомотически от 0 до 99");
int swit = Convert.ToInt32(Console.ReadLine());

switch (swit)
{
    case 1:
        for (int i = 0; i < mass.Length; i++)
        {
            mass[i] = Vod("Введите цифру -" + i);

        }

        break;

    case 2:

        for (int i = 0; i < mass.Length; i++)
        {
            mass[i] = Randoms();
        }

        break;

    default:
        Console.WriteLine("Вы вели не допустимый вариант");

        break;
}

Console.WriteLine("Ввывод масива ");
for (int i = 0; i < mass.Length; i++)
{
    Console.WriteLine(mass[i]);
}

