using System;

class Program
{
    static void Main()
    {
        // Генерация случайного массива чисел
        Random random = new Random();
        int arraySize = 10; // Размер массива 
        int[] numbers = new int[arraySize];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 51); // Генерация случайных чисел от 1 до 50
        }

        // Проверка уникальности элементов
        bool allUnique = true;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];
            bool isDuplicate = false;

            for (int j = 0; j < numbers.Length; j++)
            {
                if (i != j && currentNumber == numbers[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (isDuplicate)
            {
                Console.WriteLine($"Элемент {currentNumber} не уникален.");
                allUnique = false;
            }
        }

        if (allUnique)
        {
            Console.WriteLine("Все элементы уникальны.");
        }
    }
}
