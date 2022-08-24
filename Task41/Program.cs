//Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите сколько чисел вы хотите ввести: ");
int M = Convert.ToInt32(Console.ReadLine());


// Метод - создание массива введениием чисел с терминала
int[] FillArrayNumber(int size)
{
    int[] array = new int[size];

        for (int i = 0; i < size; i++)
    {
        Console.Write("Введите чисело: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
// Вызов метода
int[] arr = FillArrayNumber(M);
Console.WriteLine($"Заданный массив: {string.Join(", ", arr)}");

// Определения количества чисел больше 0
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    sum += 1;
       
}
Console.WriteLine($"В массиве {sum} числа больше 0");