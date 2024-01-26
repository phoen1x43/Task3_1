using System;
public class OneMassive
{
    static void Main(string[] args)
    {
        int[] array = RndOrHands();
        GetAverage(int[] array);
        DeleteMoreThanOneHundred(int[] array);
        GetNonDuplicates(int[] array);
        
        public RndOrHands(int a; bool t = false)
        {
            if (t = false)
            {
                RndFill();
            }
            else
            {
                FillByUser();
            }
        }
    }
    public void RndFill()
    {
        Random rnd = new Random;
        int[] array = new int[rnd];
        for (int i = 0; i<rnd; i++)
        {
            array[i] = rnd.Next(1, 100);
        }
    }

    public void FillByUser()
    {
        Console.WriteLine("Введите количество элементов массива");
        int n = Console.ReadLine();
        int[] array = new int[n];
        Console.WriteLine("Введите элементы массива");
        for (int i = 0; i<n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    
    public double GetAverage(int n)
    {
        int count = 0;
        foreach (int i in array)
        {
            count += i;
            Console.WriteLine("Среднее значение в массиве:");
            return count / n;
        }
    }

    public int DeleteMoreThanOneHundred(int[] array)    
    {    
        int[] minnumbers = new int[];
        minnumbersindex = 0;
        foreach (int i in array)
        {
            if (i < 100 and i > -100)
            {
                minnumbers[minnumbersindex] = array[i];
                minnumbersindex++;
            }      
        }
        array = new int[minnumbersindex];
        Console.WriteLine("Обновленный массив без элементов, больших 100 по модулю:");
        for (int i = 0; i < minnumbersindex; i++)
        {
            array[i] = minnumbers[i];
            return minnumbers;
        }
    }
    
    public int GetNonDuplicates(int[] array)
    {
        int[] NonDuplicates = new int[];
        nonduplicatesindex = 0;
        Array.Sort(array);
        foreach (int i in array)
        {
            if (array[i] != array[i+1] and array[i] != array[i-1])
            {
                NonDuplicates[nonduplicatesindex] = array[i];
                nonduplicatesindex++;
            }
        }
        array = new int[nonduplicatesindex];
        for (int i = 0; i < nonduplicatesindex; i++)
        {
            array[i] = NonDuplicates[i];
            return NonDuplicates
        }

    }

}

public class TwoMassive
{
    static void Main(string[] args)
    {
        int[,] array2d = RndOrHands2();
        GetAverage2D(int[,] array2d);
        PrintArray2D(int[,] array2d);
    
        public RndOrHands2(int a; bool t = false)
        {
            if (t = false)
            {
                RndFill2();
            }
            else
            {
                FillByUser2();
            }
        }

    }

    public void RndFill2()
    {
        Random rnd = new Random;
        int[] strings = new int[rnd];
        int[] columns = new int[rnd];
        int[,] array2d = new int[strings, columns]
        for (int i = 0; i < strings; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array2d[i, j] = i * columns + j + 1;
            }
        }
    }

    public void FillByUser2()
    {
        Console.WriteLine("Введите количество строк");
        int strings = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов");
        int columns = Convert.ToInt32(Console.ReadLine());
        int[,] array2d = new int[strings, columns]
        for (int i = 0; i < strings; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array2d[i, j] = i * columns + j + 1;
            }
        }
    }

    public double GetAverage2D(int strings, int columns)
    {   
        int count = 0;
        foreach (int i in array2d)
        {
            count += i;
            Console.WriteLine("Среднее значение в двумерном массиве:");
            return count / (strings*columns)
        }
    }
    public int PrintArray2D(int[,] array2d)
    {
        int strings = array2d.GetLength(0);
        int columns = array2d.GetLength(1);
        for (int i = 0; i < strings; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine("Двумерный массив:")
                Console.Write(array2d[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = strings - 1; i >= strings; i--)
        {
            for (int j = columns - 1; j >= columns; j--)
            {
                Console.WriteLine("Перевернутый двумерный массив:")
                Console.Write(array2d[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}


public class ThreeMassive
{
    static void Main(string[] args)
    {
        int[][] jArray = RndOrHands3();
        GetAverage3D(jArray);
        ModifyElements(jArray);
        
        public RndOrHands3(int a; bool t = false)
        {
            if (t = false)
            {
                RndFill3();
            }
            else
            {
                FillByUser3();
            }      
        }

    }
    public void RndFill3()
    {
        Random rnd = new Random();
        int strings = rnd.Next(1, 7)
        int[][] jArray = new int[strings][];
        for (int i = 0; i < strings; i++)
        {
            int columns = rnd.Next(1, 7)
            jArray[i] = new int[columns];
            for (int j = 0; j < columns; j++)
            {
                jArray[i][j] = rnd.Next(1, 26)
            }
        }
    }

    public void FillByUser3()
    {
        Console.WriteLine($"Введите количество строк: ");
        int strings = Convert.ToInt32(Console.ReadLine());
        int[][] jArray = new int[strings][];
        for (int i = 0; i < strings; i++)
        {
            Console.WriteLine($"Введите количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            jArray[i] = new int[columns];
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"Введите элемент ступенчатого массива: ");
                jArray[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }
  
    }

    public void GetAverage3D(int strings, int columns)
    {
        int N = 0;
        int sum = 0;
        double average = 0;
        for (int i = 0; i < strings; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                N++;
                sum += jArray[i][j];
                double average = sum / N;
                Console.WriteLine("Среднее значение в массиве");
                Console.Write(average);
            }
        }
        Console.Writeline();
    
    }
    public int ModifyElements(int[][] jArray)
    {
        for (int i = 0; i < jArray.Length; i++)
        {
            for (int j = 0; j < jArray[i].Length; j++)
            {
                if (jArray[i][j] % 2 == 0)
                {
                    jArray[i][j] = i * j;
                }
            }
        }
        Console.Writeline("Обновленный трехмерный массив");
        return jArray;
    }

}

