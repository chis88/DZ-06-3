// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите длинну массива: ");

int LengthArray = Convert.ToInt32((Console.ReadLine()));

int[] array = new int[LengthArray];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите {i} элементов массива");
    array [i] = Convert.ToInt32(Console.ReadLine ());
}




// int lenArray = ReadInt("Введите длинну массива: ");

// int[] randomArray = new int[lenArray];
// for (int i = 0; i < randomArray.Length; i++)
// {
// randomArray[i] = new Random().Next(1,9);
// Console.Write(randomArray[i] + " ");
//}

// int ReadInt(string message)
// {
//  Console.Write(message);
//  return Convert.ToInt32(Console.ReadLine());
// }