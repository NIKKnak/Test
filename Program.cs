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
        Hero elf = new Hero(new Elf());
        elf.Run();
        elf.Hit();


    }

    abstract class Weapon()
    {
        public abstract void Hit();
    }

    abstract class Movement()
    {
        public abstract void Move();
    }


    class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("стреляем из арбалета");
        }
    }

    class Run : Movement
    {
        public override void Move()
        {
            Console.WriteLine("бежим");
        }
    }

    //-------------
    abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }


    class Elf : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new Run();
        }
        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }

    class Hero
    {
        private Weapon _weapon;
        private Movement _movement;

        public Hero(HeroFactory heroFactory)
        {
            _weapon = heroFactory.CreateWeapon();
            _movement = heroFactory.CreateMovement();
        }
        public void Run()
        {
            _movement.Move();
        }
        public void Hit()
        {
            _weapon.Hit();
        }
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