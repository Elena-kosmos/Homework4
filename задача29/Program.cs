// напишите программу, которая задает массив из 8 элементов
// и выводит их на экран
// 1,2,5,7,19 ->[1, 2, 5, 7, 19]

    int [] array = new int [5];
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    
Console.WriteLine($"массив: [{String.Join(";", array)}]");

 

    