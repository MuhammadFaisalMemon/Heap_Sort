using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER ARRAY LENGHT:");
            int size = Convert.ToInt16(Console.ReadLine());
            int[] array1 = new int[size];
            for (int i = 0; i < size; i++)
            {
                array1[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("heap sort:");
            heap_sort hs1 = new heap_sort();
            hs1.heapsort(array1);
            hs1.print(array1);




        }
    }

    class heap_sort
    {

        public void heapsort(int[] arr)
        {
            int n = arr.Length;
            build_heap(arr);


            for (int i = n - 1; i >= 0; i--)
            {
                int swap = arr[0];
                arr[0] = arr[i];
                arr[i] = swap;
                heapify(arr, i, 0);
            }
        }
        public void build_heap(int[] arr1)
        {
            int heap_size = arr1.Length;
            for (int i = (heap_size / 2) - 1; i >= 0; i--)
            {
                heapify(arr1, heap_size, i);

            }
        }
        public void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && (arr[left] > arr[largest]))
            {
                largest = left;
            }

            if (right < n && (arr[right] > arr[largest]))
            {
                largest = right;
            }

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);

            }

        }
        public void print(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ", array[i]);
            }
        }

    }
}