Console.WriteLine(">>> PHẦN 4: CHƯƠNG 6 - CÂY ");
Console.WriteLine("------------------------------------------------------------");

Console.WriteLine("=== Bài 1: Đếm số nút trên cây nhị phân ===");
C6_Bai1();

Console.WriteLine("=== Bài 2: Tính tổng giá trị các nút ===");
C6_Bai2();

Console.WriteLine("=== Bài 3: Hiển thị giá trị các nút ===");
C6_Bai3();

Console.WriteLine("=== Bài 4: Hiển thị các nút có giá trị chẵn ===");
C6_Bai4();

Console.WriteLine("=== Bài 5: Đếm các nút có giá trị chẵn ===");
C6_Bai5();

Console.WriteLine("=== Bài 6: Đếm số con của một nút ===");
C6_Bai6();

Console.WriteLine("=== Bài 7: Hiển thị các nút trên cây con trái ===");
C6_Bai7();

Console.WriteLine("=== Bài 8: Duyệt cây theo các thứ tự ===");
C6_Bai8();






static TNode C6_TaoCay() => new TNode(8)
{
    Left = new TNode(3)
    {
        Left = new TNode(1),
        Right = new TNode(6) { Left = new TNode(4), Right = new TNode(7) }
    },
    Right = new TNode(10)
    {
        Right = new TNode(14) { Left = new TNode(13) }
    }
};

static void C6_Bai1()
{
    TNode root = C6_TaoCay();
    Console.WriteLine("Số nút trên cây: " + Dem(root));

    static int Dem(TNode? p) => p == null ? 0 : 1 + Dem(p.Left) + Dem(p.Right);
}

static void C6_Bai2()
{
    TNode root = C6_TaoCay();
    Console.WriteLine("Tổng giá trị các nút: " + Tong(root));

    static int Tong(TNode? p) => p == null ? 0 : p.Data + Tong(p.Left) + Tong(p.Right);
}

static void C6_Bai3()
{
    TNode root = C6_TaoCay();
    Console.Write("Các nút trên cây (duyệt giữa): ");
    HienThi(root);
    Console.WriteLine();

    static void HienThi(TNode? p)
    {
        if (p == null) return;
        HienThi(p.Left);
        Console.Write(p.Data + " ");
        HienThi(p.Right);
    }
}

static void C6_Bai4()
{
    TNode root = C6_TaoCay();
    Console.Write("Các nút có giá trị chẵn: ");
    HienThiChan(root);
    Console.WriteLine();

    static void HienThiChan(TNode? p)
    {
        if (p == null) return;
        HienThiChan(p.Left);
        if (p.Data % 2 == 0) Console.Write(p.Data + " ");
        HienThiChan(p.Right);
    }
}

static void C6_Bai5()
{
    TNode root = C6_TaoCay();
    Console.WriteLine("Số nút có giá trị chẵn: " + DemChan(root));

    static int DemChan(TNode? p)
    {
        if (p == null) return 0;
        return (p.Data % 2 == 0 ? 1 : 0) + DemChan(p.Left) + DemChan(p.Right);
    }
}

static void C6_Bai6()
{
    TNode root = C6_TaoCay();
    int[] canTim = { 8, 10, 7, 99 };
    foreach (int x in canTim)
    {
        TNode? nut = Tim(root, x);
        if (nut == null) { Console.WriteLine($"Nút {x}: không có trên cây"); continue; }
        Console.WriteLine($"Nút {x}: có {SoCon(nut)} con");
    }

    static TNode? Tim(TNode? p, int x)
    {
        if (p == null || p.Data == x) return p;
        return Tim(p.Left, x) ?? Tim(p.Right, x);       // tìm bên trái trước, không thấy thì sang phải
    }

    static int SoCon(TNode p) => (p.Left != null ? 1 : 0) + (p.Right != null ? 1 : 0);
}

static void C6_Bai7()
{
    TNode root = C6_TaoCay();
    Console.Write("Các nút trên cây con trái: ");
    if (root.Left == null) Console.Write("(không có)");
    else HienThi(root.Left);
    Console.WriteLine();

    static void HienThi(TNode? p)
    {
        if (p == null) return;
        HienThi(p.Left);
        Console.Write(p.Data + " ");
        HienThi(p.Right);
    }
}

static void C6_Bai8()
{
    TNode root = C6_TaoCay();

    Console.Write("Duyệt trước  (NLR): "); NLR(root); Console.WriteLine();
    Console.Write("Duyệt giữa   (LNR): "); LNR(root); Console.WriteLine();
    Console.Write("Duyệt sau    (LRN): "); LRN(root); Console.WriteLine();

    // Duyệt theo mức: dùng Queue
    Console.Write("Duyệt theo mức    : ");
    Queue<TNode> q = new Queue<TNode>();
    q.Enqueue(root);
    while (q.Count > 0)
    {
        TNode nut = q.Dequeue();
        Console.Write(nut.Data + " ");
        if (nut.Left != null) q.Enqueue(nut.Left);
        if (nut.Right != null) q.Enqueue(nut.Right);
    }
    Console.WriteLine();

    static void NLR(TNode? p)
    {
        if (p == null) return;
        Console.Write(p.Data + " ");
        NLR(p.Left);
        NLR(p.Right);
    }

    static void LNR(TNode? p)
    {
        if (p == null) return;
        LNR(p.Left);
        Console.Write(p.Data + " ");
        LNR(p.Right);
    }

    static void LRN(TNode? p)
    {
        if (p == null) return;
        LRN(p.Left);
        LRN(p.Right);
        Console.Write(p.Data + " ");
    }
}
class TNode
{
    public int Data;
    public TNode? Left, Right;
    public TNode(int data) { Data = data; }
}