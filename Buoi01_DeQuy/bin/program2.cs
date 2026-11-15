//using System.Numerics;

//class Chuong2
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;

//        // Bài tập chương 2
//        Console.WriteLine("=== Bài 1 ===");
//        Bai1();

//        Console.WriteLine("=== Bài 2 ===");
//        Bai2();

//        Console.WriteLine("=== Bài 3 ===");
//        Bai3();

//        Console.WriteLine("=== Bài 4 ===");
//        Bai4();

//        Console.WriteLine("=== Bài 5: ===");
//        Bai5();
//    }
//    static void Bai1()
//    {
//        static void Hanoi(int n, char a, char b, char c)
//        {
//            if (n == 0) return;
//            Hanoi(n - 1, a, c, b);
//            Console.WriteLine($"{a} -> {c}");
//            Hanoi(n - 1, b, a, c);
//        }
//    }

//    static void Bai2()
//    {
//        int[] a = { 1, 3, 5, 7, 9, 11, 13, 15, 17 };

//        Console.Write("Nhap so can tim: ");
//        int x = int.Parse(Console.ReadLine());

//        int left = 0;
//        int right = a.Length - 1;
//        int vitri = -1;

//        while (left <= right)
//        {
//            int mid = (left + right) / 2;

//            if (a[mid] == x)
//            {
//                vitri = mid;
//                break;
//            }
//            else if (a[mid] < x)
//            {
//                left = mid + 1;
//            }
//            else
//            {
//                right = mid - 1;
//            }
//        }

//        if (vitri != -1)
//            Console.WriteLine("Tim thay tai vi tri: " + vitri);
//        else
//            Console.WriteLine("Khong tim thay!");
//    }

//    static bool KiemTra2(int n)
//    {
//        if (n < 2)
//            return false;

//        for (int i = 2; i <= Math.Sqrt(n); i++)
//        {
//            if (n % i == 0)
//                return false;
//        }

//        return true;
//    }

//    static void Bai3()
//    {
//        Console.Write("Nhap n: ");
//        int n = int.Parse(Console.ReadLine());

//        if (KiemTra2(n))
//        {
//            Console.WriteLine(n + " la so nguyen to");
//        }
//        else
//        {
//            Console.WriteLine(n + " khong phai la so nguyen to");
//        }
//    }
//    static bool SoHoanHao(int n)
//    {
//        int tong = 0;

//        for (int i = 1; i < n; i++)
//        {
//            if (n % i == 0)
//            {
//                tong += i;
//            }
//        }

//        return tong == n;
//    }

//    static void Bai4()
//    {
//        Console.Write("Nhap N: ");
//        int N = int.Parse(Console.ReadLine());

//        for (int i = 1; i < N; i++)
//        {
//            if (SoHoanHao(i))
//            {
//                Console.Write(i + " ");
//            }
//        }
//    }

//    static void Bai5()
//    {
//        int n;
//        Console.Write("Nhap n: ");
//        n = int.Parse(Console.ReadLine());

//        BigInteger a = 0;
//        BigInteger b = 1;

//        for (int i = 0; i < n; i++)
//        {
//            BigInteger c = a + b;
//            a = b;
//            b = c;
//        }

//        Console.WriteLine("Fibonacci = " + a);
//    }

//    static void Bai6()
//    {
//        Console.Write("Nhap so luong phan tu n: ");
//        int n = int.Parse(Console.ReadLine());

//        double[] a = new double[n];

//        // Nhap mang
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write("a[{0}] = ", i);
//            a[i] = double.Parse(Console.ReadLine());
//        }

//        // Sap xep noi bot
//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = 0; j < n - 1 - i; j++)
//            {
//                if (a[j] > a[j + 1])
//                {
//                    double temp = a[j];
//                    a[j] = a[j + 1];
//                    a[j + 1] = temp;
//                }
//            }
//        }

//        // Xuat mang sau khi sap xep
//        Console.WriteLine("Day sau khi sap xep tang dan:");

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write(a[i] + " ");
//        }
//    }
//}
