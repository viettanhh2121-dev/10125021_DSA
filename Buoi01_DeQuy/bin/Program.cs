using System.Diagnostics;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// PHẦN 1: CHƯƠNG 1 - ÔN TẬP C# & MẢNG (BÀI 1 ĐẾN 5)
Console.WriteLine(">>> PHẦN 1: CHƯƠNG 1 ");
Console.WriteLine("------------------------------------------------------------");

Console.WriteLine("=== Bài 1: Tìm Max, Min trong mảng 1000 số ngẫu nhiên ===");
C1_Bai1();

Console.WriteLine("\n=== Bài 2: Trò chơi FizzBuzz (1 đến 100) ===");
C1_Bai2();

Console.WriteLine("\n=== Bài 3: Đảo ngược chuỗi ===");
C1_Bai3();

Console.WriteLine("\n=== Bài 4: Sắp xếp nổi bọt mảng 1000 phần tử ===");
C1_Bai4();

Console.WriteLine("\n=== Bài 5: Tính số Fibonacci thứ n ===");
C1_Bai5();



// PHẦN 2: CHƯƠNG 2 - THUẬT TOÁN & THÁP HÀ NỘI (BÀI 1 ĐẾN 6)

Console.WriteLine("\n>>> PHẦN 2: CHƯƠNG 2 ");
Console.WriteLine("------------------------------------------------------------");

Console.WriteLine("=== Bài 1: Bài toán Tháp Hà Nội ===");
C2_Bai1();

Console.WriteLine("\n=== Bài 2: So sánh tìm kiếm tuần tự và nhị phân ===");
C2_Bai2();

Console.WriteLine("\n=== Bài 3: Kiểm tra số nguyên tố (2 giải thuật) ===");
C2_Bai3();

Console.WriteLine("\n=== Bài 4 & 6: Demo và so sánh thời gian chạy 5 thuật toán sắp xếp ===");
C2_Bai4Va6();

Console.WriteLine("\n=== Bài 5: 4 giải thuật tính Fibonacci ===");
C2_Bai5();


// PHẦN 3: CHƯƠNG 3 - CÁC BÀI TOÁN ĐỆ QUY (BÀI 1 ĐẾN 8)

Console.WriteLine("\n>>> PHẦN 3: CHƯƠNG 3 ");
Console.WriteLine("------------------------------------------------------------");

Console.WriteLine("=== Bài 1: Tính S(n) = 1 + 2 + ... + n ===");
C3_Bai1();

Console.WriteLine("\n=== Bài 2: Tính S(n) = 1^2 + 2^2 + ... + n^2 ===");
C3_Bai2();

Console.WriteLine("\n=== Bài 3: Tính S(n) = 1 + 1/2 + ... + 1/n ===");
C3_Bai3();

Console.WriteLine("\n=== Bài 4: Tính x^n ===");
C3_Bai4();

Console.WriteLine("\n=== Bài 5: Tìm ước số lẻ lớn nhất của n ===");
C3_Bai5();

Console.WriteLine("\n=== Bài 6: Tìm ước chung lớn nhất UCLN(a, b) ===");
C3_Bai6();

Console.WriteLine("\n=== Bài 7: Đếm số lượng chữ số của n ===");
C3_Bai7();

Console.WriteLine("\n=== Bài 8: Tính căn bậc 2 lồng nhau S(n) ===");
C3_Bai8();



#region CHƯƠNG 1
static void C1_Bai1()
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

static void C1_Bai2()
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

static void C1_Bai3()
{
    string s = "Vudcanh123";
    Console.WriteLine("Chuỗi đầu vào: " + s);
    string kq = "";
    for (int i = s.Length - 1; i >= 0; i--) kq += s[i];
    Console.WriteLine("Chuỗi đảo ngược: " + kq);
}

static void C1_Bai4()
{
    int[] a = new int[1000];
    Random rd = new Random(10125179);
    for (int i = 0; i < a.Length; i++) a[i] = rd.Next(1, 101);

    Console.WriteLine("Mảng ban đầu (20 phần tử đầu):");
    Console.WriteLine(string.Join(" ", a.Take(20)));

    for (int i = 0; i < a.Length - 1; i++)
        for (int j = 0; j < a.Length - 1 - i; j++)
            if (a[j] > a[j + 1])
            {
                int tam = a[j];
                a[j] = a[j + 1];
                a[j + 1] = tam;
            }

    Console.WriteLine("Mảng sau khi sắp xếp tăng dần (20 phần tử đầu):");
    Console.WriteLine(string.Join(" ", a.Take(20)));
}

static void C1_Bai5()
{
    int n = 10;
    Console.WriteLine($"Nhập n: {n}");
    Console.WriteLine($"Số Fibonacci thứ {n} là: {Fib(n)}");

    static long Fib(int k)
    {
        if (k <= 1) return k;
        long a = 0, b = 1;
        for (int i = 2; i <= k; i++)
        {
            long c = a + b;
            a = b;
            b = c;
        }
        return b;
    }
}
#endregion

#region CHƯƠNG 2
static void C2_Bai1()
{
    int dem = 0, n = 3;
    Console.WriteLine($"Chạy thử Tháp Hà Nội với {n} đĩa:");
    HaNoi(n, 'A', 'B', 'C', ref dem);
    Console.WriteLine("Tổng số lần chuyển: " + dem);

    static void HaNoi(int k, char A, char B, char C, ref int dem)
    {
        if (k == 1)
        {
            dem++;
            Console.WriteLine($"Chuyển đĩa 1 từ {A} sang {C}");
            return;
        }
        HaNoi(k - 1, A, C, B, ref dem);
        dem++;
        Console.WriteLine($"Chuyển đĩa {k} từ {A} sang {C}");
        HaNoi(k - 1, B, A, C, ref dem);
    }
}

static void C2_Bai2()
{
    int[] kichThuoc = { 1000, 100000, 1000000 };
    for (int k = 0; k < kichThuoc.Length; k++)
    {
        int n = kichThuoc[k];
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = i * 2;
        int canTim = -1;

        Stopwatch sw = Stopwatch.StartNew();
        for (int lan = 0; lan < 10; lan++) TimTuanTu(a, n, canTim);
        sw.Stop();
        long tick1 = sw.ElapsedTicks;

        sw.Restart();
        for (int lan = 0; lan < 10; lan++) TimNhiPhan(a, n, canTim);
        sw.Stop();
        long tick2 = sw.ElapsedTicks;

        Console.WriteLine($"n = {n}: Tuần tự = {tick1} ticks, Nhị phân = {tick2} ticks");
    }

    static int TimTuanTu(int[] a, int n, int x)
    {
        for (int i = 0; i < n; i++) if (a[i] == x) return i;
        return -1;
    }

    static int TimNhiPhan(int[] a, int n, int x)
    {
        int dau = 0, cuoi = n - 1;
        while (dau <= cuoi)
        {
            int giua = (dau + cuoi) / 2;
            if (a[giua] == x) return giua;
            else if (a[giua] < x) dau = giua + 1;
            else cuoi = giua - 1;
        }
        return -1;
    }
}

static void C2_Bai3()
{
    int n = 79;
    Console.WriteLine($"Kiểm tra số {n}:");
    if (KiemTra1(n)) Console.WriteLine($"Giải thuật 1 (O(n)): {n} là số nguyên tố");
    else Console.WriteLine($"Giải thuật 1 (O(n)): {n} không là số nguyên tố");
    if (KiemTra2(n)) Console.WriteLine($"Giải thuật 2 (O(sqrt(n))): {n} là số nguyên tố");
    else Console.WriteLine($"Giải thuật 2 (O(sqrt(n))): {n} không là số nguyên tố");

    static bool KiemTra1(int k)
    {
        if (k < 2) return false;
        for (int i = 2; i < k; i++) if (k % i == 0) return false;
        return true;
    }

    static bool KiemTra2(int k)
    {
        if (k < 2) return false;
        for (int i = 2; i * i <= k; i++) if (k % i == 0) return false;
        return true;
    }
}

static void C2_Bai4Va6()
{
    Random rd = new Random(10125179);
    double[] goc = new double[10];
    for (int i = 0; i < 10; i++) goc[i] = Math.Round(rd.NextDouble() * 100, 2);

    Console.WriteLine("Dãy ban đầu: " + string.Join("  ", goc));

    // Bài 4: demo kết quả của từng thuật toán trên dãy 10 phần tử
    double[] t;
    t = (double[])goc.Clone(); BubbleSort(t);
    Console.WriteLine("Nổi bọt:  " + string.Join("  ", t));
    t = (double[])goc.Clone(); SelectionSort(t);
    Console.WriteLine("Chọn:     " + string.Join("  ", t));
    t = (double[])goc.Clone(); InsertionSort(t);
    Console.WriteLine("Chèn:     " + string.Join("  ", t));
    t = (double[])goc.Clone(); QuickSort(t, 0, t.Length - 1);
    Console.WriteLine("Nhanh:    " + string.Join("  ", t));
    t = (double[])goc.Clone(); MergeSort(t, 0, t.Length - 1);
    Console.WriteLine("Trộn:     " + string.Join("  ", t));

    // Bài 6: so sánh thời gian chạy
    int[] kichThuoc = { 1000, 5000, 10000 };
    Console.WriteLine("\nSo sánh thời gian chạy 5 thuật toán sắp xếp (ms):");
    Console.WriteLine($"{"n",8} {"Nổi bọt",10} {"Chọn",10} {"Chèn",10} {"Nhanh",10} {"Trộn",10}");
    foreach (int n in kichThuoc)
    {
        double[] x = new double[n];
        for (int i = 0; i < n; i++) x[i] = rd.NextDouble() * 100000;

        long tBubble = DoThoiGian(x, c => BubbleSort(c));
        long tSelect = DoThoiGian(x, c => SelectionSort(c));
        long tInsert = DoThoiGian(x, c => InsertionSort(c));
        long tQuick = DoThoiGian(x, c => QuickSort(c, 0, c.Length - 1));
        long tMerge = DoThoiGian(x, c => MergeSort(c, 0, c.Length - 1));

        Console.WriteLine($"{n,8} {tBubble,10} {tSelect,10} {tInsert,10} {tQuick,10} {tMerge,10}");
    }

    static long DoThoiGian(double[] x, Action<double[]> sort)
    {
        double[] c = (double[])x.Clone();
        Stopwatch sw = Stopwatch.StartNew();
        sort(c);
        sw.Stop();
        return sw.ElapsedMilliseconds;
    }
}

static void BubbleSort(double[] a)
{
    for (int i = 0; i < a.Length - 1; i++)
        for (int j = 0; j < a.Length - 1 - i; j++)
            if (a[j] > a[j + 1])
            {
                double tam = a[j]; a[j] = a[j + 1]; a[j + 1] = tam;
            }
}

static void SelectionSort(double[] a)
{
    for (int i = 0; i < a.Length - 1; i++)
    {
        int vt = i;
        for (int j = i + 1; j < a.Length; j++)
            if (a[j] < a[vt]) vt = j;
        double tam = a[i]; a[i] = a[vt]; a[vt] = tam;
    }
}

static void InsertionSort(double[] a)
{
    for (int i = 1; i < a.Length; i++)
    {
        double key = a[i];
        int j = i - 1;
        while (j >= 0 && a[j] > key)
        {
            a[j + 1] = a[j];
            j--;
        }
        a[j + 1] = key;
    }
}

static void QuickSort(double[] a, int l, int r)
{
    if (l >= r) return;
    int i = l, j = r;
    double p = a[(l + r) / 2];
    while (i <= j)
    {
        while (a[i] < p) i++;
        while (a[j] > p) j--;
        if (i <= j)
        {
            double tam = a[i]; a[i] = a[j]; a[j] = tam;
            i++; j--;
        }
    }
    if (l < j) QuickSort(a, l, j);
    if (i < r) QuickSort(a, i, r);
}

static void MergeSort(double[] a, int l, int r)
{
    if (l >= r) return;
    int m = (l + r) / 2;
    MergeSort(a, l, m);
    MergeSort(a, m + 1, r);

    double[] tmp = new double[r - l + 1];
    int i = l, j = m + 1, k = 0;
    while (i <= m && j <= r) tmp[k++] = (a[i] <= a[j]) ? a[i++] : a[j++];
    while (i <= m) tmp[k++] = a[i++];
    while (j <= r) tmp[k++] = a[j++];
    Array.Copy(tmp, 0, a, l, tmp.Length);
}

static void C2_Bai5()
{
    int n = 20;
    Console.WriteLine($"Tính Fibonacci thứ {n}:");
    Console.WriteLine("Giải thuật 1 (đệ quy):          " + Fib1(n));
    Console.WriteLine("Giải thuật 2 (vòng lặp):        " + Fib2(n));

    long[] nho = new long[n + 2];
    Array.Fill(nho, -1);
    Console.WriteLine("Giải thuật 3 (đệ quy có nhớ):   " + Fib3(n, nho));
    Console.WriteLine("Giải thuật 4 (fast doubling):   " + Fib4(n).Item1);

    static long Fib1(int k) { if (k <= 1) return k; return Fib1(k - 1) + Fib1(k - 2); }

    static long Fib2(int k)
    {
        if (k <= 1) return k;
        long a = 0, b = 1;
        for (int i = 2; i <= k; i++) { long c = a + b; a = b; b = c; }
        return b;
    }

    static long Fib3(int k, long[] m)
    {
        if (k <= 1) return k;
        if (m[k] != -1) return m[k];
        return m[k] = Fib3(k - 1, m) + Fib3(k - 2, m);
    }

    // Trả về (F(k), F(k+1)) - độ phức tạp O(log n)
    static (long, long) Fib4(int k)
    {
        if (k == 0) return (0, 1);
        var (a, b) = Fib4(k / 2);
        long c = a * (2 * b - a);
        long d = a * a + b * b;
        return (k % 2 == 0) ? (c, d) : (d, c + d);
    }
}
#endregion

#region CHƯƠNG 3
static void C3_Bai1()
{
    int n = 10;
    Console.WriteLine($"Nhập n: {n} -> S({n}) = {S1(n)}");
    static int S1(int k) => k == 1 ? 1 : S1(k - 1) + k;
}

static void C3_Bai2()
{
    int n = 5;
    Console.WriteLine($"Nhập n: {n} -> S({n}) = {S2(n)}");
    static int S2(int k) => k == 1 ? 1 : S2(k - 1) + k * k;
}

static void C3_Bai3()
{
    int n = 5;
    Console.WriteLine($"Nhập n: {n} -> S({n}) = {S3(n):F4}");
    static double S3(int k) => k == 1 ? 1 : S3(k - 1) + 1.0 / k;
}

static void C3_Bai4()
{
    double x = 2.0; int n = 5;
    Console.WriteLine($"Nhập x: {x}, n: {n} -> {x}^{n} = {Pow(x, n)}");
    static double Pow(double b, int k)
    {
        if (k == 0) return 1;
        if (k < 0) return 1.0 / Pow(b, -k);
        return Pow(b, k - 1) * b;
    }
}

static void C3_Bai5()
{
    int n = 100;
    Console.WriteLine($"Nhập n: {n} -> Ước lẻ lớn nhất của {n} là: {UocLe(n)}");
    static int UocLe(int k) => (k % 2 == 1) ? k : UocLe(k / 2);
}

static void C3_Bai6()
{
    int a = 48, b = 18;
    Console.WriteLine($"Nhập a: {a}, b: {b} -> UCLN({a}, {b}) = {UCLN(a, b)}");
    static int UCLN(int x, int y) => (x % y == 0) ? y : UCLN(y, x % y);
}

static void C3_Bai7()
{
    long n = 10125179;
    Console.WriteLine($"Nhập n: {n} -> Số {n} có {SoCS(n)} chữ số");
    static int SoCS(long k) => (k == 0) ? 0 : SoCS(k / 10) + 1;
}

static void C3_Bai8()
{
    int n = 4;
    Console.WriteLine($"Nhập n: {n} -> S({n}) = {Can(1, n):F4}");
    static double Can(int i, int k) => (i == k) ? Math.Sqrt(k) : Math.Sqrt(i + Can(i + 1, k));
}
#endregion
