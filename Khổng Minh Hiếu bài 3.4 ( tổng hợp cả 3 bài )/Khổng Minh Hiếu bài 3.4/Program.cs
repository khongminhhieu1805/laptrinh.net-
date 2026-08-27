using System;
//bài 1
class Program
{
    
    static void Bai1_Calculator()
    {
        Console.Clear();

        Console.Write("Nhập số thứ nhất a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhập phép toán (+, -, *, /, %): ");
        char op = char.Parse(Console.ReadLine());

        try
        {
            double result = op switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,

                '/' => b == 0
                    ? throw new DivideByZeroException()
                    : a / b,

                '%' => b == 0
                    ? throw new DivideByZeroException()
                    : a % b,

                _ => throw new ArgumentException("Phép toán không hợp lệ!")
            };

            Console.WriteLine($"Kết quả: {result:F2}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Lỗi: Không thể chia cho 0!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }

        Console.WriteLine("\nNhấn phím bất kỳ để quay lại Menu...");
        Console.ReadKey();
    }


    //bài 2
    static void Bai2_PhuongTrinhBac2()
    {
        Console.Clear();

        Console.Write("Nhập a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhập c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                else
                    Console.WriteLine("Phương trình vô nghiệm.");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Phương trình có nghiệm x = {x:F2}");
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"x1 = {x1:F2}");
                Console.WriteLine($"x2 = {x2:F2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Nghiệm kép x = {x:F2}");
            }
            else
            {
                Console.WriteLine("Vô nghiệm.");
            }
        }

        Console.WriteLine("\nNhấn phím bất kỳ để quay lại Menu...");
        Console.ReadKey();
    }


    //bài 3

    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static bool IsPerfectNumber(int n)
    {
        if (n <= 1)
            return false;

        int sum = 1;

        int i = 2;

        while (i <= n / 2)
        {
            if (n % i == 0)
                sum += i;

            i++;
        }

        return sum == n;
    }

    static void Bai3_SoNguyenToFibonacci()
    {
        Console.Clear();

        int N;

        do
        {
            Console.Write("Nhập N nguyên dương: ");
            N = int.Parse(Console.ReadLine());
        }
        while (N <= 0);

        // Kiểm tra số nguyên tố
        if (IsPrime(N))
            Console.WriteLine($"{N} là Số nguyên tố!");
        else
            Console.WriteLine($"{N} KHÔNG là Số nguyên tố.");

        // Kiểm tra số hoàn hảo
        if (IsPerfectNumber(N))
            Console.WriteLine($"{N} là Số hoàn hảo!");
        else
            Console.WriteLine($"{N} KHÔNG là Số hoàn hảo.");

        // Fibonacci
        Console.Write($"Dãy Fibonacci {N} số: ");

        long f1 = 0;
        long f2 = 1;

        for (int i = 1; i <= N; i++)
        {
            Console.Write(f1);

            if (i < N)
                Console.Write(", ");

            long next = f1 + f2;
            f1 = f2;
            f2 = next;
        }

        Console.WriteLine();

        Console.WriteLine("\nNhấn phím bất kỳ để quay lại Menu...");
        Console.ReadKey();
    }


    //menu chính
    static void Main()
    {
        int choice;

        do
        {
            Console.Clear();

            Console.WriteLine("==================================");
            Console.WriteLine("          MENU BÀI TẬP C#");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Chạy Bài tập 1 (Calculator)");
            Console.WriteLine("2. Chạy Bài tập 2 (Phương trình bậc 2)");
            Console.WriteLine("3. Chạy Bài tập 3 (Số nguyên tố & Fibonacci)");
            Console.WriteLine("0. Thoát chương trình");
            Console.WriteLine("==================================");

            Console.Write("Nhập lựa chọn: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Bai1_Calculator();
                    break;

                case 2:
                    Bai2_PhuongTrinhBac2();
                    break;

                case 3:
                    Bai3_SoNguyenToFibonacci();
                    break;

                case 0:
                    Console.Clear();
                    Console.WriteLine("Đã thoát chương trình!");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    Console.WriteLine("\nNhấn phím bất kỳ để thử lại...");
                    Console.ReadKey();
                    break;
            }

        } while (choice != 0);
    }
}
