// Console.WriteLine("hello world");
// int [] array = new int[3];
// Array(array);
// Printarray(array);
// Console.Write($"{array[array.Length-1]}");



// void Printarray(int [] arr)

// {
//     for (int i = 0; i < arr.Length-1; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
    

// }





class Program
{
    static void Main()
    {
        // Ввод исходного массива с клавиатуры
        Console.Write("Введите элементы массива через пробел: ");
        string[] inputArray = Console.ReadLine().Split(' ');

        

        // Вывод результата
        Console.WriteLine("Исходный массив: {0}", string.Join(", ", inputArray));
        
    }
}
