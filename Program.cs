
using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int> { 1, 65, 89, 00, 5, 3, 790 };
        List<int> sortedList = InsertionSort(list);
    }

   

    public static void SelectionSort(int[] input)
    {
        for (var i = 0; i < input.Length; i++)
        {
            var min = i;
            for (var j = i + 1; j < input.Length; j++)
            {
                if (input[min] > input[j])
                {
                    min = j;
                }
            }
            if (min != i)
            {
                var lowerValue = input[min];
                input[min] = input[i];
                input[i] = lowerValue;
            }
        }
    }

    static void heapSort(int[] arr, int n)
    {
        for (int i = n / 2 - 1; i >= 0; i--)
            heapify(arr, n, i);
        for (int i = n - 1; i >= 0; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;
            heapify(arr, i, 0);
        }
    }
    static void heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        if (left < n && arr[left] > arr[largest])
            largest = left;
        if (right < n && arr[right] > arr[largest])
            largest = right;
        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;
            heapify(arr, n, largest);
        }
    }
}

