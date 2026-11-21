Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine(">>> PHẦN 2: CHƯƠNG 4 - MẢNG VÀ DANH SÁCH LIÊN KẾT");
Console.WriteLine("------------------------------------------------------------");

Console.WriteLine("=== Bài 1: Nhập, hiển thị và chèn phần tử x vào vị trí k ===");
C4_Bai1();

Console.WriteLine("=== Bài 2: Quản lý danh sách nhân viên ===");
C4_Bai2();

Console.WriteLine("=== Bài 3: Các hàm xử lý ma trận vuông ===");
C4_Bai3();

Console.WriteLine("=== Bài 4: Danh sách liên kết đơn (đếm x, min dương, xóa x) ===");
C4_Bai4();

Console.WriteLine("=== Bài 5: Các bài toán trên danh sách liên kết đơn ===");
C4_Bai5();







static void C4_Bai1()
{
    // a. Nhập n số nguyên dương a[0], a[1], ..., a[n-1]
    Console.Write("Nhập n: ");
    int n = int.Parse(Console.ReadLine() ?? "0");
    int[] a = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Nhập a[{i}]: ");
        a[i] = int.Parse(Console.ReadLine() ?? "0");
    }

    // b. Hiển thị danh sách, các phần tử cách nhau 1 khoảng trống
    Console.WriteLine("Danh sách: " + string.Join(" ", a));

    // c. Chèn phần tử x vào vị trí k
    Console.Write("Nhập x cần chèn: ");
    int x = int.Parse(Console.ReadLine() ?? "0");
    int k;
    do
    {
        Console.Write($"Nhập vị trí k (0 đến {n}): ");
        k = int.Parse(Console.ReadLine() ?? "0");
    } while (k < 0 || k > n);

    int[] tmp = new int[a.Length + 1];                      // mảng trung gian dài a.Length + 1
    for (int i = 0; i < k; i++) tmp[i] = a[i];              // chép các phần tử trước vị trí k
    tmp[k] = x;                                             // đặt x vào vị trí k
    for (int i = k; i < a.Length; i++) tmp[i + 1] = a[i];   // chép phần còn lại, dịch sang phải 1
    a = tmp;                                                // gán lại a = tmp

    Console.WriteLine("Danh sách sau khi chèn: " + string.Join(" ", a));
}

static void C4_Bai2()
{
    NhanVien[] DS =
    {
        new NhanVien { MaNV = "NV01", Hoten = "Nguyễn Văn An",  Namsinh = 1990, Phongban = "Kế toán",  LuongCB = 9000000,  Thuong = 1500000 },
        new NhanVien { MaNV = "NV02", Hoten = "Trần Thị Bình",  Namsinh = 1995, Phongban = "Kỹ thuật", LuongCB = 12000000, Thuong = 800000 },
        new NhanVien { MaNV = "NV03", Hoten = "Lê Hoàng Cường", Namsinh = 1988, Phongban = "Kế toán",  LuongCB = 8500000,  Thuong = 1200000 },
        new NhanVien { MaNV = "NV04", Hoten = "Phạm Minh Dũng", Namsinh = 1992, Phongban = "Nhân sự",  LuongCB = 8500000,  Thuong = 2000000 },
    };

    // a, b, c: gộp chung một vòng lặp vì cùng duyệt danh sách
    long tong = 0; int min = int.MaxValue, dem = 0;
    for (int i = 0; i < DS.Length; i++)
    {
        tong += ThucLinh(DS[i]);                              // a
        if (DS[i].LuongCB < min) min = DS[i].LuongCB;         // b (tìm min)
        if (DS[i].Thuong >= 1200000) dem++;                   // c
    }
    Console.WriteLine($"a. Tổng thực lĩnh: {tong:N0}");
    Console.WriteLine($"b. Nhân viên có lương CB thấp nhất ({min:N0}):");
    for (int i = 0; i < DS.Length; i++) if (DS[i].LuongCB == min) In(DS[i]);
    Console.WriteLine($"c. Số nhân viên thưởng >= 1200000: {dem}");

    // d. Phòng ban tăng dần, trùng phòng ban thì mã NV giảm dần
    Array.Sort(DS, (u, w) => u.Phongban != w.Phongban
        ? string.Compare(u.Phongban, w.Phongban)
        : string.Compare(w.MaNV, u.MaNV));
    Console.WriteLine("d. Sau khi sắp xếp:");
    foreach (var nv in DS) In(nv);

    // e. Tăng lương cơ bản 5%
    for (int i = 0; i < DS.Length; i++)
        DS[i].LuongCB = (int)Math.Round(DS[i].LuongCB * 1.05);
    Console.WriteLine("e. Sau khi tăng lương 5%:");
    foreach (var nv in DS) In(nv);

    static int ThucLinh(NhanVien v) => v.LuongCB + v.Thuong;

    static void In(NhanVien v) =>
        Console.WriteLine($"   {v.MaNV} | {v.Hoten} | {v.Namsinh} | {v.Phongban} | CB {v.LuongCB:N0} | Thưởng {v.Thuong:N0}");
}

static void C4_Bai3()
{
    int n = 4;
    int[,] a = new int[n, n];
    Random rd = new Random(10125179);
    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++) a[i, j] = rd.Next(-9, 21);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++) Console.Write($"{a[i, j],4}");
        Console.WriteLine();
    }

    Console.WriteLine("a. Tổng tất cả các phần tử: " + TongMaTran(a, n));

    int minDuong = MinDuong(a, n);
    Console.WriteLine("b. Giá trị dương nhỏ nhất: " + (minDuong == int.MaxValue ? "không có" : minDuong.ToString()));

    Console.WriteLine("c. Tổng đường chéo phụ: " + TongCheoPhu(a, n));
    Console.WriteLine("d. Đường chéo chính tăng dần: " + (CheoChinhTangDan(a, n) ? "Có" : "Không"));

    static int TongMaTran(int[,] m, int k)
    {
        int t = 0;
        for (int i = 0; i < k; i++)
            for (int j = 0; j < k; j++) t += m[i, j];
        return t;
    }

    static int MinDuong(int[,] m, int k)
    {
        int min = int.MaxValue;
        for (int i = 0; i < k; i++)
            for (int j = 0; j < k; j++)
                if (m[i, j] > 0 && m[i, j] < min) min = m[i, j];
        return min;
    }

    static int TongCheoPhu(int[,] m, int k)
    {
        int t = 0;
        for (int i = 0; i < k; i++)
            for (int j = 0; j < k; j++)
                if (j == (k - 1) - i) t += m[i, j];
        return t;
    }

    static bool CheoChinhTangDan(int[,] m, int k)
    {
        int[] tg = new int[k];
        for (int i = 0; i < k; i++) tg[i] = m[i, i];
        for (int i = 0; i < k - 1; i++)
            for (int j = i + 1; j < k; j++)
                if (tg[i] >= tg[j]) return false;   // gặp 1 cặp không tăng thì dừng
        return true;
    }
}

static void C4_Bai4()
{
    Node? pHead = TaoDS(new[] { 5, 12, 7, 12, 3, 9, 12, 20 });
    Console.WriteLine("Danh sách: " + InDS(pHead));

    int x = 12, d = 0, minDuong = int.MaxValue;
    for (var p = pHead; p != null; p = p.Link)
    {
        if (p.Data == x) d++;                                      // a
        if (p.Data > 0 && p.Data < minDuong) minDuong = p.Data;    // b
    }
    Console.WriteLine($"a. Số phần tử bằng {x}: {d}");
    Console.WriteLine("b. Dương nhỏ nhất: " + (minDuong == int.MaxValue ? "không có" : minDuong.ToString()));

    pHead = Xoa(pHead, x);                                         // c
    Console.WriteLine($"c. Sau khi xóa {x} đầu tiên: " + InDS(pHead));

    static Node? TaoDS(int[] arr)             // chèn từ cuối mảng lên đầu danh sách
    {
        Node? head = null;
        for (int i = arr.Length - 1; i >= 0; i--) head = new Node { Data = arr[i], Link = head };
        return head;
    }

    static string InDS(Node? h)
    {
        string s = "";
        for (var q = h; q != null; q = q.Link) s += q.Data + " ";
        return s.TrimEnd();
    }

    static Node? Xoa(Node? head, int giaTri)  // xóa nút có giá trị giaTri đầu tiên
    {
        if (head == null) return null;
        if (head.Data == giaTri) return head.Link;                        // nằm ở đầu
        for (var q = head; q.Link != null; q = q.Link)
            if (q.Link.Data == giaTri) { q.Link = q.Link.Link; break; }   // nằm ở giữa hoặc cuối
        return head;
    }
}


static void C4_Bai5()
{
    Node? l = TaoDS(new[] { 7, -3, 0, 11, 4, -8, 0, 13, 4, 9 });
    Console.WriteLine("Danh sách l: " + InDS(l));

    int x = 4, max = int.MinValue, tong = 0, nt = 0, am = 0, duong = 0, khong = 0, dx = 0, minDuong = int.MaxValue;
    for (var p = l; p != null; p = p.Link)      // duyệt 1 lần cho cả 6 câu
    {
        int v = p.Data;
        if (v > max) max = v;                   // a
        tong += v;                              // b
        if (KTNT(v)) nt++;                      // c
        if (v < 0) am++; else if (v > 0) duong++; else khong++;   // d
        if (v == x) dx++;                       // e
        if (v > 0 && v < minDuong) minDuong = v;                  // f
    }
    Console.WriteLine($"a. Lớn nhất: {max}");
    Console.WriteLine($"b. Tổng: {tong}");
    Console.WriteLine($"c. Số nguyên tố: {nt}");
    Console.WriteLine($"d. Âm: {am}, dương: {duong}, bằng 0: {khong}");
    Console.WriteLine($"e. Số phần tử bằng {x}: {dx}");
    Console.WriteLine("f. Dương nhỏ nhất: " + (minDuong == int.MaxValue ? "không có" : minDuong.ToString()));

    static bool KTNT(int k)
    {
        if (k < 2) return false;
        for (int i = 2; i * i <= k; i++) if (k % i == 0) return false;
        return true;
    }

    static Node? TaoDS(int[] arr)             // chèn từ cuối mảng lên đầu danh sách
    {
        Node? head = null;
        for (int i = arr.Length - 1; i >= 0; i--) head = new Node { Data = arr[i], Link = head };
        return head;
    }

    static string InDS(Node? h)
    {
        string s = "";
        for (var q = h; q != null; q = q.Link) s += q.Data + " ";
        return s.TrimEnd();
    }
}
struct NhanVien
{
    public string MaNV, Hoten, Phongban;
    public int Namsinh, LuongCB, Thuong;
}

class Node
{
    public int Data;
    public Node? Link;
}