using System;
using System.Linq;

namespace grigorievg
{
    class Variant1
    {
        static void Main()
        {
            // Примеры вызова методов первого варианта | Вызовы всех методов (можно было и использовать console.readline для вызова каждого из них отдельно)
            OppositeNumber(); // "4" → "-4", "-25" → "25"
            UppercaseLetter(); // "иванов иван иванович" → "Иванов Иван Иванович", "петров дмитрий владимирович" → "Петров Дмитрий Владимирович"
            RockPaperScissors(); // "камень", "ножницы" --> "Игрок 1 победил!", "ножницы", "бумага" --> "Игрок 1 победил!", "бумага", "бумага" --> "Ничья!"
            ReverseList(); // "3,2,1" → "1,2,3"
            Bonus(); // Bonus? (10000, true) → "$100000", Bonus? (10000, false) → "$10000"
            BattleOfCharacters(); // battle("ONE", "TWO") --> "TWO - сильнее", battle("FOUR", "FIVE") --> "FOUR - сильнее", battle("ONE", "NEO") --> "Ничья!"
            BulletsAndDragons(); // (10, 5) → да, (100, 40) → да, (4, 5) → нет, (1500, 751) → нет
            Empty(); // (1, 5) → 2, 3, 4, (10, 11) → «empty»
            RedSquare(); // new double[] {2, 1.62}, new double[] {0, 0}, new double[] {14.05, 80}
            Anagram(); // ("mama", "amam") → true, ("jock", "lock") → false, ("Twoo", "Woot") → true
            PluxOne(1, 5); // (1, 5) → "1, 3, 5, 7, 9"
            Game(7, 3); // Попробуйте угадать сами! (правильное число 7)
            Name("иванов иван иванович"); // "иванов иван иванович" → "Иванов Иван Иванович"
        }

        // Opposite number (Math-Task)
        static void OppositeNumber()
        {
            int num = 4;
            Console.WriteLine($"Opposite Number of {num} is {num * -1}");
            num = -25;
            Console.WriteLine($"Opposite Number of {num} is {Math.Abs(num)}");

            // OppositeNumber принимает целое число num, меняет его знак на противоположный и выводит результат
        }

        // Uppercase letter (Fundametals-Task)
        static void UppercaseLetter()
        {
            string name = "иванов иван иванович";
            string upperCaseName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name);
            Console.WriteLine($"Uppercase name: {upperCaseName}");

            name = "петров дмитрий владимирович";
            upperCaseName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name);
            Console.WriteLine($"Uppercase name: {upperCaseName}");

            // Метод UppercaseLetter принимает строку name, преобразует первую букву каждого слова в верхний регистр и выводит результат
        }

        // Rock Paper Scissors! (Game-Task)
        static void RockPaperScissors()
        {
            string playerOne = "камень";
            string playerTwo = "ножницы";
            if ((playerOne == "камень" && playerTwo == "ножницы") ||
                (playerOne == "ножницы" && playerTwo == "бумага") ||
                (playerOne == "бумага" && playerTwo == "камень"))
            {
                Console.WriteLine("Игрок 1 победил!");
            }
            else if ((playerTwo == "камень" && playerOne == "ножницы") ||
                     (playerTwo == "ножницы" && playerOne == "бумага") ||
                     (playerTwo == "бумага" && playerOne == "камень"))
            {
                Console.WriteLine("Игрок 2 победил!");
            }
            else
            {
                Console.WriteLine("Ничья!");
            }

            // Метод RockPaperScissors принимает две строки для игрока 1 и игрока 2, сравнивает их выборы и определяет победителя/ничью в игре "Камень, ножницы или бумага"
        }
        //static void Rabbits()
        //{
        //
        //}
        // Reverse list (Fundametals-Task)
        static void ReverseList()
        {
            int[] array = { 3, 2, 1 };
            Array.Reverse(array);
            Console.WriteLine("Reversed list: " + string.Join(",", array));
            // Метод ReverseList принимает массив целых чисел array, переворачивает его и выводит результат
        }

        // Bonus? (Math-Task)
        static void Bonus()
        {
            int salary = 10000;
            bool bonus = true;

            int total = bonus ? salary * 10 : salary;
            Console.WriteLine($"Bonus? ({salary}, {bonus}) → ${total}");
            // Метод Bonus принимает зарплату salary и флаг премии bonus, умножает зарплату на 10, если премия истина, и выводит результат со знаком "$"
        }

        // Battle of the characters (Game-Task)
        static void BattleOfCharacters()
        {
            string x = "ONE";
            string y = "NEO";

            int powerX = 0;
            foreach (char c in x)
            {
                int power = c - 'A' + 1;
                powerX += power;
            }

            int powerY = 0;
            foreach (char c in y)
            {
                int power = c - 'A' + 1;
                powerY += power;
            }

            if (powerX > powerY)
                Console.WriteLine($"{x} - сильнее");
            else if (powerY > powerX)
                Console.WriteLine($"{y} - сильнее");
            else
                Console.WriteLine("Ничья!");

            // Метод BattleOfCharacters принимает две строки x и y, вычисляет общую силу каждой группы персонажей и определяет победителя или ничью по заданным правилам
        }
        // Bullets and dragons (Game-Task)
        static void BulletsAndDragons()
        {
            int bullets = 10;
            int dragons = 5;
            Console.WriteLine(bullets >= dragons * 2 ? "да" : "нет");

            // Метод BulletsAndDragons проверяет, выживет ли герой, учитывая количество пуль и драконов
        }

        // Empty (Algorithmic-Task)
        static void Empty()
        {
            int a = 1;
            int b = 5;
            if (b - a <= 1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = a + 1; i < b; i++)
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine();
            }

            // Метод Empty выводит числа в промежутке между a и b через запятую или сообщает "empty", если таких чисел нет
        }

        // Red square(Math-Task)
        static void RedSquare()
        {
            double a = 2;
            double sideLength = a / (2 * Math.PI);
            double area = sideLength * sideLength;
            Console.WriteLine(Math.Round(area, 2));

            // Метод RedSquare расчитывает площадь красного квадрата по длине дуги окружности
        }

        // Anagram (Fundametals-Task)
        static void Anagram()
        {
            string test = "mama";
            string original = "amam";

            test = test.ToLower();
            original = original.ToLower();

            char[] testArray = test.ToCharArray();
            char[] originalArray = original.ToCharArray();

            Array.Sort(testArray);
            Array.Sort(originalArray);

            bool isAnagram = testArray.SequenceEqual(originalArray);
            Console.WriteLine(isAnagram);

            // Метод Anagram проверяет, являются ли две строки анаграммами и выводит результат true или false
        }
        // PluxOne (Algorithmic-Task)
        static void PluxOne(int a, int b)
        {
            string result = "";
            for (int i = a; i <= b; i++)
            {
                result += i + ", " + (i * 2 - 1) + ", ";
            }
            Console.WriteLine(result.TrimEnd(' ', ','));

            //Метод PluxOne выводит числа от a до b, прибавляя к каждому последующему числу 1
        }

        // Empty (Game-Task)
        static void Game(int number, int lives)
        {
            Console.WriteLine("Угадайте число от 1 до 10!");
            int guessCount = 0;
            while (guessCount < lives)
            {
                int guess = int.Parse(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("Корректно!");
                    return;
                }
                else
                {
                    Console.WriteLine("Неправильно!");
                }
                guessCount++;
            }
            Console.WriteLine("Ну всё, game over!");

            // Метод Game реализует простую игру угадай числа с ограничением по количеству попыток
        }

        // Name(Fundametals-Task)
        static void Name(string name)
        {
            string upperCaseName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name);
            Console.WriteLine(upperCaseName);
        }

        // Метод Name принимает строку name, преобразует первую букву каждого слова в верхний регистр и выводит результат
    }
}
