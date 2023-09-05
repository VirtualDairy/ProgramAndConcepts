// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] notsortedArray= { 6, 5, 3, 1, 8, 7, 2, 4 };
//PrintArray(new StraightInsertionSort().SortedList(notsortedArray));

PrintArray(new BubbleSort().SortedList(notsortedArray));
static void PrintArray(int[] list)
{
    foreach(int i in list)
    {
        Console.Write($"{i},");
    }
}