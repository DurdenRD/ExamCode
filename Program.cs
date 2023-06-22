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

        // Создание нового массива из строк, длина которых меньше или равна 3
        string[] outputArray = new string[inputArray.Length]; 
        
        // Создание результирующего массива необходимого размера
int outputIndex = 0; // Индекс следующего элемента в результирующем массиве
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                outputArray[outputIndex] = inputArray[i];
                outputIndex++;
            }
        }
        // Вывод результата
        Console.WriteLine("Исходный массив: {0}", string.Join(", ", inputArray));
        
    }
}
