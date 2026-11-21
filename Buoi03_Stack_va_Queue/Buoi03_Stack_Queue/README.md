# Buổi 03 – Stack và Queue

Họ tên: Vũ Việt Anh · MSV: 10125021

## Bài đã làm
Chương 1: Bài 1, 2, 3, 4, 5
Chương 2: Bài 1, 2, 3, 4, 5, 6
Chương 3: Bài 1, 2, 3, 4, 5, 6, 7, 8

## Cách chạy
```bash
dotnet run --project Buoi03_Stack_Queue/<Ten_Chuong>/<Ten_Bai>
```

## Kết quả chạy
~~~
>>> PHẦN 5: CHƯƠNG 5 - NGĂN XẾP (STACK) & HÀNG ĐỢI (QUEUE)
------------------------------------------------------------
=== Bài 1: Kiểm tra tính đúng đắn của biểu thức toán học ===
(a + b) * [c - {d / e}]    -> Hợp lệ
((a + b)                   -> Sai
{[(a + b)]}                -> Hợp lệ
(a + b]                    -> Sai
a + b)                     -> Sai
=== Bài 2: Mô phỏng lịch sử trình duyệt web ===
Trang hiện tại: google.com
Truy cập youtube.com       -> Hiện tại: youtube.com   | Back: 1, Forward: 0
Truy cập facebook.com      -> Hiện tại: facebook.com  | Back: 2, Forward: 0
Truy cập github.com        -> Hiện tại: github.com    | Back: 3, Forward: 0
Back                       -> Hiện tại: facebook.com  | Back: 2, Forward: 1
Back                       -> Hiện tại: youtube.com   | Back: 1, Forward: 2
Forward                    -> Hiện tại: facebook.com  | Back: 2, Forward: 1
Truy cập jolibee.com       -> Hiện tại: jolibee.com   | Back: 3, Forward: 0
Forward (không được)       -> Hiện tại: jolibee.com   | Back: 3, Forward: 0
Back                       -> Hiện tại: facebook.com  | Back: 2, Forward: 1
Back                       -> Hiện tại: youtube.com   | Back: 1, Forward: 2
Back                       -> Hiện tại: google.com    | Back: 0, Forward: 3
Back (không được)          -> Hiện tại: google.com    | Back: 0, Forward: 3
=== Bài 3: Mô phỏng Function Call Stack ===
Main gọi GiaiThua(4):
  Gọi   GiaiThua(4) | tham số = 4 | địa chỉ trả về: Main | độ sâu Stack: 2
  Gọi   GiaiThua(3) | tham số = 3 | địa chỉ trả về: GiaiThua(4) | độ sâu Stack: 3
  Gọi   GiaiThua(2) | tham số = 2 | địa chỉ trả về: GiaiThua(3) | độ sâu Stack: 4
  Gọi   GiaiThua(1) | tham số = 1 | địa chỉ trả về: GiaiThua(2) | độ sâu Stack: 5
Các hàm lần lượt kết thúc:
  Trả về GiaiThua(1) = 1 cho GiaiThua(2) | độ sâu Stack: 4
  Trả về GiaiThua(2) = 2 cho GiaiThua(3) | độ sâu Stack: 3
  Trả về GiaiThua(3) = 6 cho GiaiThua(4) | độ sâu Stack: 2
  Trả về GiaiThua(4) = 24 cho Main | độ sâu Stack: 1
Main nhận kết quả 4! = 24. Stack rỗng: True
=== Bài 4: Mô phỏng hệ thống in ấn ===
Thêm yêu cầu in: BaoCao.docx  (đang chờ: 1)
Thêm yêu cầu in: HoaDon.pdf   (đang chờ: 2)
Thêm yêu cầu in: AnhThe.png   (đang chờ: 3)
Đang in: BaoCao.docx (còn chờ: 2)
Thêm yêu cầu in: DonXinNghi.docx (đang chờ: 3)
Đang in: HoaDon.pdf (còn chờ: 2)
Đang in: AnhThe.png (còn chờ: 1)
Đang in: DonXinNghi.docx (còn chờ: 0)
=== Bài 5: Mô phỏng đường truyền dữ liệu ===
Gói #1 "Xin chào": đã xử lý, độ trễ 15 ms
Gói #2 "Dữ liệu A": đã xử lý, độ trễ 30 ms
Gói #3 "Dữ liệu B": đã xử lý, độ trễ 45 ms
Gói #4 "Dữ liệu C": LỖI đường truyền, bị mất
Gói #5 "Dữ liệu D": đã xử lý, độ trễ 75 ms
Gói #6 "Kết thúc": đã xử lý, độ trễ 90 ms
Tổng kết: bị mất 1 gói, tổng độ trễ 255 ms
=== Bài 6: Quản lý hàng đợi tại ngân hàng ===
Hàng đợi (3 khách):
  1. Nguyễn Văn An    | Gửi tiền      | 08:00
  2. Trần Thị Bình    | Rút tiền      | 08:05
  3. Lê Hoàng Cường   | Chuyển khoản  | 08:10
Phục vụ: Nguyễn Văn An - Gửi tiền (đến lúc 08:00)
Hàng đợi (3 khách):
  1. Trần Thị Bình    | Rút tiền      | 08:05
  2. Lê Hoàng Cường   | Chuyển khoản  | 08:10
  3. Phạm Minh Dũng   | Mở tài khoản  | 08:20
Phục vụ: Trần Thị Bình - Rút tiền (đến lúc 08:05)
Phục vụ: Lê Hoàng Cường - Chuyển khoản (đến lúc 08:10)
Phục vụ: Phạm Minh Dũng - Mở tài khoản (đến lúc 08:20)
Hàng đợi (0 khách):
  (trống)
  ~~~