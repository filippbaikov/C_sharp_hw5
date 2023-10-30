Console.Clear();
// Напишите программу, которая подсчитывает количество четных элементов в массиве целых 
// положительных трехзначных чисел и выводит результат на экран.
// int[] a = generateArray();
// printArray(a);
// System.Console.WriteLine();
// System.Console.WriteLine("четные получи :");
// countEvenElements(a);
// System.Console.WriteLine("нечетные получи :");
// SumOddElements(a);

//Напишите программу для работы с массивом вещественных чисел.
double[] b = randomDoubleArray();
printDoubleArray(b);
System.Console.WriteLine("\n максимальный: " + FindMax(b));
System.Console.WriteLine("\n минимаьлный: " + FindMin(b));
System.Console.WriteLine("\n рзница между мин и макс: "+CalcDifferenceBetweenMaxMin(b));





bool countEvenElements(int[] array)
{   // который принимает массив целых положительных трехзначных чисел и 
    // возвращает количество четных элементов в массиве.
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            System.Console.Write(array[i] + " ");

        }

    }

    return false;
}
void printArray(int[] array)
{    // принимает массив из метода  generateArray() выводит массив на экран.
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] generateArray()
{//принимает данные из консоли,возвращает сформированный массив, передаёт методу printArray
    System.Console.WriteLine("введи размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("введи минимальное значение: ");
    int min = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("введи максимальное значение: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}
bool SumOddElements(int[] array)
{   // который принимает массив целых положительных трехзначных чисел и 
    // возвращает количество четных элементов в массиве.
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) != 0)
        {
            System.Console.Write(array[i] + " ");

        }

    }

    return false;
}

double[] randomDoubleArray()
{
    //принимает данные из консоли,возвращает сформированный массив, передаёт методу printDoubleArray
    System.Console.WriteLine("введи размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("введи минимальное значение: ");
    double min = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("введи максимальное значение: ");
    double max = Convert.ToDouble(Console.ReadLine());
    Random random = new Random();
    double[] array = new double[size];


    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble() * (max - min) + min;
    }
    return array;
}
void printDoubleArray(double[] array)
{    // принимает массив из метода  randomDoubleArray() выводит массив на экран.
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] > max)
            max = array[i];

    }
    return max;


}
double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] < min)
            min = array[i];

    }
    return min;

}
double CalcDifferenceBetweenMaxMin(double[] array)
{
double diff=FindMax(array)-FindMin(array);
return diff;
}