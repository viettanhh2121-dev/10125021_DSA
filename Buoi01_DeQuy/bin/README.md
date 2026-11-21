# Buổi 01 – Đệ quy

Họ tên: Vũ Việt Anh · MSV: 10125021

## Bài đã làm
Chương 1: Bài 1, 2, 3, 4, 5
Chương 2: Bài 1, 2, 3, 4, 5, 6
Chương 3: Bài 1, 2, 3, 4, 5, 6, 7, 8

## Cách chạy
```bash
dotnet run --project Buoi01_DeQuy/<Ten_Chuong>/<Ten_Bai>
```

## Kết quả chạy
~~~
>>> PHẦN 1: CHƯƠNG 1
------------------------------------------------------------
=== Bài 1: Tìm Max, Min trong mảng 1000 số ngẫu nhiên ===
Số lớn nhất là:  1000
Số nhỏ nhất là:  0

=== Bài 2: Trò chơi FizzBuzz (1 đến 100) ===
1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
Fizz
16
17
Fizz
19
Buzz
Fizz
22
23
Fizz
Buzz
26
Fizz
28
29
Fizz
31
32
Fizz
34
Buzz
Fizz
37
38
Fizz
Buzz
41
Fizz
43
44
Fizz
46
47
Fizz
49
Buzz
Fizz
52
53
Fizz
Buzz
56
Fizz
58
59
Fizz
61
62
Fizz
64
Buzz
Fizz
67
68
Fizz
Buzz
71
Fizz
73
74
Fizz
76
77
Fizz
79
Buzz
Fizz
82
83
Fizz
Buzz
86
Fizz
88
89
Fizz
91
92
Fizz
94
Buzz
Fizz
97
98
Fizz
Buzz

=== Bài 3: Đảo ngược chuỗi ===
Chuỗi đầu vào: Vudcanh123
Chuỗi đảo ngược: 321hnacduV

=== Bài 4: Sắp xếp nổi bọt mảng 1000 phần tử ===
Mảng ban đầu (20 phần tử đầu):
55 85 30 44 14 28 18 83 72 15 77 98 66 20 42 90 70 17 19 6
Mảng sau khi sắp xếp tăng dần (20 phần tử đầu):
1 1 1 1 1 1 2 2 2 2 2 2 2 2 2 2 2 3 3 3

=== Bài 5: Tính số Fibonacci thứ n ===
Nhập n: 10
Số Fibonacci thứ 10 là: 55

>>> PHẦN 2: CHƯƠNG 2
------------------------------------------------------------
=== Bài 1: Bài toán Tháp Hà Nội ===
Chạy thử Tháp Hà Nội với 3 đĩa:
Chuyển đĩa 1 từ A sang C
Chuyển đĩa 2 từ A sang B
Chuyển đĩa 1 từ C sang B
Chuyển đĩa 3 từ A sang C
Chuyển đĩa 1 từ B sang A
Chuyển đĩa 2 từ B sang C
Chuyển đĩa 1 từ A sang C
Tổng số lần chuyển: 7

=== Bài 2: So sánh tìm kiếm tuần tự và nhị phân ===
n = 1000: Tuần tự = 1838 ticks, Nhị phân = 2661 ticks
n = 100000: Tuần tự = 9969 ticks, Nhị phân = 6 ticks
n = 1000000: Tuần tự = 113591 ticks, Nhị phân = 11 ticks

=== Bài 3: Kiểm tra số nguyên tố (2 giải thuật) ===
Kiểm tra số 79:
Giải thuật 1 (O(n)): 79 là số nguyên tố
Giải thuật 2 (O(sqrt(n))): 79 là số nguyên tố

=== Bài 4 & 6: Demo và so sánh thời gian chạy 5 thuật toán sắp xếp ===
Dãy ban đầu: 54.65  84.24  29.05  43.66  13.71  27.93  17.13  82.22  71.45  14.38
Nổi bọt:  13.71  14.38  17.13  27.93  29.05  43.66  54.65  71.45  82.22  84.24
Chọn:     13.71  14.38  17.13  27.93  29.05  43.66  54.65  71.45  82.22  84.24
Chèn:     13.71  14.38  17.13  27.93  29.05  43.66  54.65  71.45  82.22  84.24
Nhanh:    13.71  14.38  17.13  27.93  29.05  43.66  54.65  71.45  82.22  84.24
Trộn:     13.71  14.38  17.13  27.93  29.05  43.66  54.65  71.45  82.22  84.24

So sánh thời gian chạy 5 thuật toán sắp xếp (ms):
       n    Nổi bọt       Chọn       Chèn      Nhanh       Trộn
    1000          1          0          0          0          0
    5000         40         15         10          0          0
   10000        196         63         46          0          1

=== Bài 5: 4 giải thuật tính Fibonacci ===
Tính Fibonacci thứ 20:
Giải thuật 1 (đệ quy):          6765
Giải thuật 2 (vòng lặp):        6765
Giải thuật 3 (đệ quy có nhớ):   6765
Giải thuật 4 (fast doubling):   6765

>>> PHẦN 3: CHƯƠNG 3
------------------------------------------------------------
=== Bài 1: Tính S(n) = 1 + 2 + ... + n ===
Nhập n: 10 -> S(10) = 55

=== Bài 2: Tính S(n) = 1^2 + 2^2 + ... + n^2 ===
Nhập n: 5 -> S(5) = 55

=== Bài 3: Tính S(n) = 1 + 1/2 + ... + 1/n ===
Nhập n: 5 -> S(5) = 2.2833

=== Bài 4: Tính x^n ===
Nhập x: 2, n: 5 -> 2^5 = 32

=== Bài 5: Tìm ước số lẻ lớn nhất của n ===
Nhập n: 100 -> Ước lẻ lớn nhất của 100 là: 25

=== Bài 6: Tìm ước chung lớn nhất UCLN(a, b) ===
Nhập a: 48, b: 18 -> UCLN(48, 18) = 6

=== Bài 7: Đếm số lượng chữ số của n ===
Nhập n: 10125179 -> Số 10125179 có 8 chữ số

=== Bài 8: Tính căn bậc 2 lồng nhau S(n) ===
Nhập n: 4 -> S(4) = 1.7488
~~~
