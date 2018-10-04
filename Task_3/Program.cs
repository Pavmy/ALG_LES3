using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Павлюков Михаил
//3. Реализовать бинарный алгоритм поиска в виде функции, которой 
//передается отсортированный массив.Функция возвращает индекс найденного 
//элемента или -1, если элемент не найден.

//# include <stdio.h>
//# include <malloc.h>
//# include <conio.h>

//int binarysearch(int a, int mass[], int n);
//void InsertionSort(int n, int mass[]);

//int main()
//{
//    //ввод N
//    int N, a;
//    printf("Input N: ");
//    scanf_s("%d", &N);
//    //выделение памяти под массив
//    int* mass;
//    mass = (int*)malloc(N * sizeof(int));
//    //ввод элементов массива
//    printf("Input the array elements:\n");
//    for (int i = 0; i < N; i++)
//        scanf_s("%d", &mass[i]);
//    //сортировка вставками
//    InsertionSort(N, mass);
//    //вывод отсортированного массива на экран
//    printf("Sorted array:\n");
//    for (int i = 0; i < N; i++)
//        printf("%d ", mass[i]);
//    printf("\n");
//    //ввод искомого элемента
//    printf("Input variable 'a' for search: ");
//    scanf_s("%d", &a);
//    int k;
//    //двоичный поиск
//    k = binarysearch(a, mass, N);
//    if (k != -1)
//    {
//        printf("The index of the element is %d\n", k);
//    }
//    else
//        printf("The element isn't found!\n");
//    //освобождение памяти
//    free(mass);
//    _getch();
//    return 0;
//}

//int binarysearch(int a, int mass[], int n)
//{
//    int low, high, middle;
//    low = 0;
//    high = n - 1;
//    while (low <= high)
//    {
//        middle = (low + high) / 2;
//        if (a < mass[middle])
//            high = middle - 1;
//        else if (a > mass[middle])
//            low = middle + 1;
//        else
//            return middle;
//    }
//    return -1;
//}

////сортировка вставками
//void InsertionSort(int n, int mass[])
//{
//    int newElement, location;

//    for (int i = 1; i < n; i++)
//    {
//        newElement = mass[i];
//        location = i - 1;
//        while (location >= 0 && mass[location] > newElement)
//        {
//            mass[location + 1] = mass[location];
//            location = location - 1;
//        }
//        mass[location + 1] = newElement;
//    }
//}

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
