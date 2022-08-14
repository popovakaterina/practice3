//Задача 19
//Напишите программу, 
//которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string strnumber = Convert.ToString(number);
if (strnumber[0]==strnumber[4] || strnumber[1]==strnumber[3])
{
    Console.WriteLine("Число является палиндромом!!!");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
//14212 -> нет
//12821 -> да
//23432 -> да