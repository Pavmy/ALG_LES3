﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Павлюков Михаил
// 1. Попробовать оптимизировать пузырьковую сортировку.
//    Сравнить количество операций сравнения оптимизированной и не оптимизированной 
//    программы. Написать функции сортировки, которые возвращают количество операций.
//#include <stdio.h>
//#include <malloc.h>

//int main()
//{
//    int N;
//    printf("Input N: ");
//    scanf_s("%d", &N);
//    int* mass;
//    mass = (int*)malloc(N * sizeof(int));
//    printf("Input the array elements:\n");
//    for (int i = 0; i < N; i++)
//        scanf_s("%d", &mass[i]);
//    //сортировка пузырьком
//    int tmp;
//    bool noSwap;

//    for (int i = N - 1; i >= 0; i--)
//    {
//        noSwap = 1;
//        for (int j = 0; j < i; j++)
//        {
//            if (mass[j] > mass[j + 1])
//            {
//                tmp = mass[j];
//                mass[j] = mass[j + 1];
//                mass[j + 1] = tmp;
//                noSwap = 0;
//            }
//        }
//        if (noSwap == 1)
//            break;
//    }
//    printf("Sorted array:\n");
//    for (int i = 0; i < N; i++)
//        printf("%d ", mass[i]);
//    printf("\n");
//    free(mass);
//    return 0;
//}

//#include <stdio.h>
//#include <stdlib.h>
//#include <time.h>

//int main(void)
//{
//    const int size1 = 5;
//    const int size2 = 2;
//    int arr1[size1];
//    int arr2[size2];

//    srand(time(NULL));

//    for (int i = 0; i < size1; i++)
//        arr1[i] = rand() % 100;

//    for (int i = 0; i < size2; i++)
//        arr2[i] = arr1[rand() % size1];

//    printf("a: ");
//    for (int i = 0; i < size1; i++)
//        printf("%d ", arr1[i]);
//    printf("\n");
//    printf("b: ");
//    for (int i = 0; i < size2; i++)
//        printf("%d ", arr2[i]);
//    printf("\n");
//    for (int left = 0, right = size1 - 1; left < right;)
//    {
//        for (int idx = left, l_idx = -1, r_idx = -1; idx <= right; idx++)
//        {
//            int i;
//            for (i = 0; i < size2; i++)
//                if (arr1[idx] == arr2[i]) break;
//            if (i == size2)
//                if (l_idx == -1) l_idx = idx;
//                else r_idx = idx;

//            if ((l_idx != -1) && (r_idx != -1))
//            {

//                if (arr1[r_idx] < arr1[l_idx])
//                {
//                    int tmp = arr1[l_idx];
//                    arr1[l_idx] = arr1[r_idx];
//                    arr1[r_idx] = tmp;
//                    idx = l_idx;
//                }
//                else
//                {
//                    idx = r_idx;
//                    l_idx = r_idx;
//                }
//                r_idx = -1;
//            }
//        }
//        right--;
//        for (int idx = right, l_idx = -1, r_idx = -1; idx >= left; idx--)
//        {
//            int i;
//            for (i = 0; i < size2; i++)
//                if (arr1[idx] == arr2[i]) break;
//            if (i == size2)
//                if (r_idx == -1) r_idx = idx;
//                else l_idx = idx;

//            if ((l_idx != -1) && (r_idx != -1))
//            {

//                if (arr1[l_idx] > arr1[r_idx])
//                {
//                    int tmp = arr1[l_idx];
//                    arr1[l_idx] = arr1[r_idx];
//                    arr1[r_idx] = tmp;
//                    idx = r_idx;

//                }
//                else
//                {
//                    idx = l_idx;
//                    r_idx = l_idx;

//                }
//                l_idx = -1;
//            }
//        }
//        left++;
//    }
//    printf("a: ");
//    for (int i = 0; i < size1; i++)
//        printf("%d ", arr1[i]);
//    printf("\n");

//    return 0;
//}

namespace ALG_LES_3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
