﻿// See https://aka.ms/new-console-template for more information
public class BubbleSort
{
    public int[] SortedList(int[] list)
    {
        for (int i = 0; i < list.Length - 1; i++)
        {
            for (int j = 0, temp = 0; j < list.Length - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }

        return list;
    }
}