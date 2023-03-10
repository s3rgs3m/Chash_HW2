/*
https://github.com/s3rgs3m/Chash_HW2
Урок 2. Базовые алгоритмы
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */
Console.Write ("Введите номер задачи 10, 13 или 15: ");
if (int.TryParse(Console.ReadLine(), out int taskNum)){
    switch (taskNum) {
        case 10: //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            Console.Clear();
            Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
            Console.Write("\nВведите число: ");
            if (int.TryParse(Console.ReadLine(), out int number10))
                if (number10 < 100 || number10 > 999)
                    Console.WriteLine ("Число должно быть трехзначным");
                else 
                    Console.WriteLine ($"Вторая цифра числа '{number10}': {number10 % 100 / 10}");
            else
                Console.WriteLine ("Число введено неправильно");
            break;

        case 13: // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            Console.Clear();
            Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
                Console.Write("\nВведите цифру: ");
                if (int.TryParse(Console.ReadLine(), out int number13)){
                    // решение через string:
                    Console.WriteLine("Решение через массив в String:");
                    string str = number13.ToString();
                    Console.WriteLine (str.Length > 2 ? $"\tТретья цифра в числе '{str}': {str[2]}" : $"\tВ числе '{str}' нет 3й цифры");

                    //решение без массива:
                    Console.WriteLine("\nРешение без массива:");
                    if (number13 / 100 >0 ){

                        int third = 0;
                        int partOfNumber = number13;
                        
                        while (partOfNumber > 99){
                            third = partOfNumber % 10;
                            partOfNumber = partOfNumber / 10;
                        }
                        Console.WriteLine($"\tТретья цифра в числе '{number13}': {third}");
                    }
                    else 
                        Console.WriteLine ($"\tВ числе '{number13}' нет 3й цифры");
                }
                else
                Console.WriteLine ("Введено не число int");
            break;

        case 15: // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            Console.Clear();
            Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
                Console.Write("\nВведите номер дня недели: ");
                if (int.TryParse(Console.ReadLine(), out int number15) && (number15 <8) && (number15 >0))
                        Console.WriteLine (number15 > 5 ? "выходной" : "рабочий");
                else
                    Console.WriteLine ("Номер дня недели введен неправильно");       
            break;
        default:
            Console.WriteLine("Такого номера задачи нет");
            break;
    }
}
else
    Console.WriteLine ("Введен не номер");