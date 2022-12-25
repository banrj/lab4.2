// Богомолов Даниил Исп2/1
// Вариант 13 уровень Высокий

Console.WriteLine("Введите размер масива: ");
int Number = int.Parse(Console.ReadLine());
Console.WriteLine("\n   Ваш массив до одзеркаливания даиганоли:\n");
int[,] massiv;
massiv = new int[Number, Number];
Random random = new Random();

for (int indexOut = 0; indexOut < Number; indexOut++)
{
    for (int indexIn = 0; indexIn < Number; indexIn++)
    {
        massiv[indexOut, indexIn] = random.Next(10);
        Console.Write(massiv[indexOut, indexIn]+ "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\n   Ваш массив после одзеркаливания даиганоли:\n");

for (int indexOut = 0; indexOut < Number; indexOut++)
{
    for (int indexIn = 0; indexIn < Number; indexIn++)
    {
        int mirror = massiv[indexOut, indexOut]; 
        int point = Number - indexOut - 1;
        
        if (indexIn == point)
        {
            massiv[indexOut, indexIn] = mirror;
        }

        Console.Write(massiv[indexOut, indexIn] + "\t");
    }
    Console.WriteLine();
}