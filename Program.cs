using System;
using Lab1;

class Program
{
    static void Main()
    {
        // Задання початкового рейтингу
        int initialRating = 50;

        // Створення об'єктів гравців
        GameAccount lolya = new GameAccount("Lolya", initialRating);
        GameAccount bolya = new GameAccount("Bolya", initialRating);
        GameAccount barabolya = new GameAccount("Barabolya", initialRating);

        // Виведення початкового рейтингу
        Console.WriteLine($"{lolya.UserName} Initial Rating: {initialRating}");
        Console.WriteLine($"{bolya.UserName} Initial Rating: {initialRating}");
        Console.WriteLine($"{barabolya.UserName} Initial Rating: {initialRating}\n");

        // Імітація кількох ігор між усіма гравцями
        lolya.PlayGame(bolya, 50, true);
        bolya.PlayGame(lolya, 50, false);

        lolya.PlayGame(bolya, 30, false);
        bolya.PlayGame(lolya, 30, true);

        lolya.PlayGame(bolya, 20, true);
        bolya.PlayGame(lolya, 20, false);

        barabolya.PlayGame(lolya, 10, true);
        lolya.PlayGame(barabolya, 10, false);

        barabolya.PlayGame(bolya, 25, false);
        bolya.PlayGame(barabolya, 25, true);

        barabolya.PlayGame(lolya, 15, true);
        lolya.PlayGame(barabolya, 15, false);

        // Виведення рейтингу та статистики для кожного гравця
        Console.WriteLine($"\n{lolya.UserName} Rating: {initialRating}");
        lolya.GetStats();

        Console.WriteLine($"\n{bolya.UserName} Rating: {initialRating}");
        bolya.GetStats();

        Console.WriteLine($"\n{barabolya.UserName} Rating: {initialRating}");
        barabolya.GetStats();
    }
}
