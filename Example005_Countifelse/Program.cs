﻿Console.WriteLine("Введите Имя пользователя: ");
string username = Console.ReadLine();

if(username == "Маша")
{
    Console.WriteLine("Ура, это же МАША");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}