// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



int Vod(string masseg)
{

    Console.WriteLine(masseg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}


int[] mass = new int[8];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = Vod("Введите цифру -" + i);
    
}

Console.WriteLine("Ввывод масива ");
for (int i = 0; i < mass.Length; i++)
{
    Console.WriteLine(mass[i]);
}

