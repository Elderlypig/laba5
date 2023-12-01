using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Чтение входных данных из файла
        string[] lines = File.ReadAllLines("Inlet.in");
        string[] input = lines[0].Split(' ');
        int N = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int C = int.Parse(input[2]);
        int[] A = Array.ConvertAll(lines[1].Split(' '), int.Parse);

        // Подсчет количества элементов, делящихся на B и C
        int count = 0;
        for (int i = 0; i < N; i++)
        {
            if (A[i] % B == 0 && A[i] % C == 0)
            {
                count++;
            }
        }

        // Запись результата в файл
        File.WriteAllText("Outlet.out", count.ToString());

        // Уведомление о записи результата в файл
        Console.WriteLine("Результат был записан в файл Outlet.out.");
    }
}
