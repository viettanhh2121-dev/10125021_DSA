using System;
using System.Diagnostics;
using System.Numerics;

class Chuong1
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Bài tập chương 1
        Console.WriteLine("=== Bài 1 ===");
        Bai1();

        Console.WriteLine("=== Bài 2 ===");
        Bai2();

        Console.WriteLine("=== Bài 3 ===");
        Bai3();

        Console.WriteLine("=== Bài 4 ===");
        Bai4();

        Console.WriteLine("=== Bài 5: ===");
        Bai5();
    }
    static void Bai1()
    {
        Random rnd = new Random();
        int[] arr = new int[1000];

        for (int i = 0; i < 1000; i++)
        {
            arr[i] = rnd.Next(0, 1001);
        }

        int max = arr[0], min = arr[0];

        foreach (int x in arr)
        {
            if (x > max) max = x;
            if (x < min) min = x;
        }

        Console.WriteLine("Số lớn nhất là:  " + max);
        Console.WriteLine("Số nhỏ nhất là:  " + min);

    }

    static void Bai2()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }

    }

    static void Bai3()
    {
        Console.WriteLine("Nhập chuỗi: ");
        string s = Console.ReadLine() ?? "";

        string kq = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            kq += s[i];
        }

        Console.WriteLine("Chuỗi đảo ngược:  " + kq);
    }

    static void Bai4()
    {
        Random rnd = new Random();
        int[] arr = new int[1000];

        for (int i = 0; i < 1000; i++)
        {
            arr[i] = rnd.Next(0, 1001);
        }


        Console.WriteLine("Mảng ban đầu: ");
        Console.WriteLine(string.Join("  ", arr));

        Array.Sort(arr);
        Console.WriteLine("Mảng sắp xếp tăng dần:  ");
        Console.WriteLine(string.Join("  ", arr));
    }

    static void Bai5()
    {
        Console.WriteLine("Nhập số nguyên dương n:  ");
        int n = int.Parse(Console.ReadLine() ?? "1");

        long a = 0, b = 1;
        for (int i = 2; i < n; i++)
        {
            long c = a + b;
            a = b;
            b = c;
        }
        Console.WriteLine("Số Fibonacci thứ " + n + " là: " + (n == 1 ? a : b));
    }
}


