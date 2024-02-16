using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using System.IO;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Diagnostics;
using System.IO;


namespace Test;

internal class Program

{


    static void Main(string[] args)
    {


        int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
        int x = 91;
        int result = BinarySearch(arr, x);
        if (result == -1)
            Console.WriteLine("Элемент не найден");
        else
            Console.WriteLine("Элемент найден в позиции " + result);

    }


    // Метод для выполнения бинарного поиска в массиве
    static int BinarySearch(int[] arr, int x)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Проверяем, если x находится в середине массива
            if (arr[mid] == x)
                return mid;

            // Если x больше, чем элемент в середине массива, игнорируем левую часть
            if (arr[mid] < x)
                left = mid + 1;
            // Иначе игнорируем правую часть
            else
                right = mid - 1;
        }

        // Если x не найден в массиве
        return -1;
    }







    [Conditional("sd")]
    public static void Greetings(Person person)
    {
        if (person is Person { role: "Admin" })
        {
            Console.WriteLine("Hi Admin");
        }
        else
            Console.WriteLine("Hi User");

    }
    class Account
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler? Notify;              // 1.Определение события
        public Account(int sum) => Sum = sum;
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Со счета снято: {sum}");   // 2.Вызов события
            }
            else
            {
                Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
            }
        }
    }
    static void Print1()
    {
        Console.WriteLine("Print1");
    }
    static void Print2()
    {
        Console.WriteLine("Print2");
    }




}