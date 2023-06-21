// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Vod(string masseg){

    Console.WriteLine(masseg);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}


int number = Vod("Введите число");
int step = Vod("Введите степень в которую хотите возвести");

 Console.WriteLine("Ответ: число " + number+ " в степени " + step + " равно - " + Math.Pow(number, step));

