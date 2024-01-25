using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using System.IO;
using System;
using System.Security.Cryptography.X509Certificates;


namespace Test
{
    internal class Program

    {


        static void Main(string[] args)
        {








        }



        public record Person
        {
            public string Name { get; set; }
            public Person(string name) => Name = name;
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
}