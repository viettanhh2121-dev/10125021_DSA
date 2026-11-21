Console.WriteLine(">>> PHẦN 3: CHƯƠNG 5 - NGĂN XẾP (STACK) & HÀNG ĐỢI (QUEUE)");
Console.WriteLine("------------------------------------------------------------");

Console.WriteLine("=== Bài 1: Kiểm tra tính đúng đắn của biểu thức toán học ===");
C5_Bai1();

Console.WriteLine("=== Bài 2: Mô phỏng lịch sử trình duyệt web ===");
C5_Bai2();

Console.WriteLine("=== Bài 3: Mô phỏng Function Call Stack ===");
C5_Bai3();

Console.WriteLine("=== Bài 4: Mô phỏng hệ thống in ấn ===");
C5_Bai4();

Console.WriteLine("=== Bài 5: Mô phỏng đường truyền dữ liệu ===");
C5_Bai5();

Console.WriteLine("=== Bài 6: Quản lý hàng đợi tại ngân hàng ===");
C5_Bai6();






static void C5_Bai1()
{
    string[] bieuThuc = { "(a + b) * [c - {d / e}]", "((a + b)", "{[(a + b)]}", "(a + b]", "a + b)" };
    foreach (string s in bieuThuc)
    {
        string kq = HopLe(s) ? "Hợp lệ" : "Sai";
        Console.WriteLine($"{s,-26} -> {kq}");
    }

    static bool HopLe(string s)
    {
        Stack<char> st = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{') st.Push(c);          // ngoặc mở: đẩy vào Stack
            else if (c == ')' || c == ']' || c == '}')                 // ngoặc đóng: kiểm tra đỉnh Stack
            {
                if (st.Count == 0) return false;                       // Stack rỗng: thừa ngoặc đóng
                char dinh = st.Pop();
                if ((c == ')' && dinh != '(') || (c == ']' && dinh != '[') || (c == '}' && dinh != '{'))
                    return false;                                      // sai loại ngoặc
            }
        }
        return st.Count == 0;                                          // hết biểu thức mà Stack rỗng thì hợp lệ
    }
}

static void C5_Bai2()
{
    Stack<string> back = new Stack<string>();       // các trang đã truy cập
    Stack<string> forward = new Stack<string>();    // các trang có thể chuyển tiếp đến
    string hienTai = "google.com";
    Console.WriteLine("Trang hiện tại: " + hienTai);

    TruyCap("youtube.com");
    TruyCap("facebook.com");
    TruyCap("github.com");
    QuayLai();
    QuayLai();
    ChuyenTiep();
    TruyCap("jolibee.com");
    ChuyenTiep();                                   // Forward đã bị xóa sạch nên không chuyển được
    QuayLai(); QuayLai(); QuayLai(); QuayLai();     // lần thứ 4 hết lịch sử

    void TruyCap(string url)
    {
        back.Push(hienTai);                         // đẩy trang hiện tại vào Back
        forward.Clear();                            // xóa sạch Forward
        hienTai = url;
        HienThi("Truy cập " + url);
    }

    void QuayLai()
    {
        if (back.Count == 0) { HienThi("Back (không được)"); return; }
        forward.Push(hienTai);                      // đẩy trang hiện tại vào Forward
        hienTai = back.Pop();                       // lấy trang từ Back ra hiển thị
        HienThi("Back");
    }

    void ChuyenTiep()
    {
        if (forward.Count == 0) { HienThi("Forward (không được)"); return; }
        back.Push(hienTai);                         // đẩy trang hiện tại vào Back
        hienTai = forward.Pop();                    // lấy trang từ Forward ra hiển thị
        HienThi("Forward");
    }

    void HienThi(string hanhDong) =>
        Console.WriteLine($"{hanhDong,-26} -> Hiện tại: {hienTai,-13} | Back: {back.Count}, Forward: {forward.Count}");
}

static void C5_Bai3()
{
    // Mỗi khung ngăn xếp gồm: tên hàm, tham số, nơi gọi (địa chỉ trả về)
    Stack<(string Ham, int ThamSo, string DiaChiTra)> stack = new();
    int n = 4;

    stack.Push(("Main", 0, "Hệ điều hành"));
    Console.WriteLine($"Main gọi GiaiThua({n}):");
    for (int k = n; k >= 1; k--)                    // gọi hàm: đẩy khung vào Stack
    {
        string noiGoi = (k == n) ? "Main" : $"GiaiThua({k + 1})";
        stack.Push(($"GiaiThua({k})", k, noiGoi));
        Console.WriteLine($"  Gọi   GiaiThua({k}) | tham số = {k} | địa chỉ trả về: {noiGoi} | độ sâu Stack: {stack.Count}");
    }

    long kq = 1;                                    // GiaiThua(1) = 1
    Console.WriteLine("Các hàm lần lượt kết thúc:");
    while (stack.Peek().Ham != "Main")              // trả về: lấy khung ra khỏi Stack
    {
        var f = stack.Pop();
        kq *= f.ThamSo;
        Console.WriteLine($"  Trả về {f.Ham} = {kq} cho {f.DiaChiTra} | độ sâu Stack: {stack.Count}");
    }
    stack.Pop();                                    // Main kết thúc
    Console.WriteLine($"Main nhận kết quả {n}! = {kq}. Stack rỗng: {stack.Count == 0}");
}

static void C5_Bai4()
{
    Queue<string> hang = new Queue<string>();
    string[] yeuCau = { "BaoCao.docx", "HoaDon.pdf", "AnhThe.png" };

    foreach (string f in yeuCau)
    {
        hang.Enqueue(f);                            // thêm yêu cầu vào cuối Queue
        Console.WriteLine($"Thêm yêu cầu in: {f,-12} (đang chờ: {hang.Count})");
    }

    Console.WriteLine($"Đang in: {hang.Dequeue()} (còn chờ: {hang.Count})");   // xử lý từ đầu Queue

    hang.Enqueue("DonXinNghi.docx");                // yêu cầu mới đến khi đang in
    Console.WriteLine($"Thêm yêu cầu in: DonXinNghi.docx (đang chờ: {hang.Count})");

    while (hang.Count > 0)
        Console.WriteLine($"Đang in: {hang.Dequeue()} (còn chờ: {hang.Count})");
}

static void C5_Bai5()
{
    // Mỗi gói tin gồm: số thứ tự, nội dung, độ trễ (ms)
    Queue<(int Id, string NoiDung, int DoTre)> mang = new();
    string[] noiDung = { "Xin chào", "Dữ liệu A", "Dữ liệu B", "Dữ liệu C", "Dữ liệu D", "Kết thúc" };
    for (int i = 0; i < noiDung.Length; i++)
        mang.Enqueue((i + 1, noiDung[i], (i + 1) * 15));    // gói thứ i có độ trễ i*15 ms

    int tongTre = 0, mat = 0;
    while (mang.Count > 0)
    {
        var g = mang.Dequeue();                     // lấy gói tin ở đầu Queue
        if (g.Id % 4 == 0)                          // mô phỏng lỗi đường truyền: gói thứ 4, 8, ... bị mất
        {
            Console.WriteLine($"Gói #{g.Id} \"{g.NoiDung}\": LỖI đường truyền, bị mất");
            mat++;
            continue;
        }
        tongTre += g.DoTre;
        Console.WriteLine($"Gói #{g.Id} \"{g.NoiDung}\": đã xử lý, độ trễ {g.DoTre} ms");
    }
    Console.WriteLine($"Tổng kết: bị mất {mat} gói, tổng độ trễ {tongTre} ms");
}

static void C5_Bai6()
{
    Queue<(string Ten, string DichVu, string GioDen)> hang = new();

    hang.Enqueue(("Nguyễn Văn An", "Gửi tiền", "08:00"));
    hang.Enqueue(("Trần Thị Bình", "Rút tiền", "08:05"));
    hang.Enqueue(("Lê Hoàng Cường", "Chuyển khoản", "08:10"));
    HienThi(hang);

    PhucVu();                                       // nhân viên rảnh: phục vụ khách ở đầu hàng
    hang.Enqueue(("Phạm Minh Dũng", "Mở tài khoản", "08:20"));   // khách mới đến cuối hàng
    HienThi(hang);

    while (hang.Count > 0) PhucVu();
    HienThi(hang);

    void PhucVu()
    {
        var kh = hang.Dequeue();
        Console.WriteLine($"Phục vụ: {kh.Ten} - {kh.DichVu} (đến lúc {kh.GioDen})");
    }

    static void HienThi(Queue<(string Ten, string DichVu, string GioDen)> q)
    {
        Console.WriteLine($"Hàng đợi ({q.Count} khách):");
        if (q.Count == 0) Console.WriteLine("  (trống)");
        int stt = 1;
        foreach (var kh in q)                       // duyệt từ đầu đến cuối hàng đợi
            Console.WriteLine($"  {stt++}. {kh.Ten,-16} | {kh.DichVu,-13} | {kh.GioDen}");
    }
}