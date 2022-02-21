// See https://aka.ms/new-console-template for more information
using System;         // Thư viện

namespace HelloWorld // sử dụng tổ chức mã, là một container cho các lớp và không gian tên khác 
{
    class Program   // là một container cho dữ liệu mang lại chức năng cho chương trình 
    {
        static void Main (string[] agrs)  // luôn xuất hiện trong chương trình, bất kì mã nào bên trong khung sẽ đc thực hiện 
        {
            /* ------------------------------ In ra màn hình ------------------------- */
            // .WriteLine() khi chạy mã trên màn hình sẽ k trên một dòng 
            // Console.WriteLine("Hello");
            // Console.WriteLine("World");
            // .Write() khi chạy mã trên màn hình sẽ trên một dòng
            // Console.Write("Hoang");
            // Console.Write("Anh");
            /* ----------------------------------------------------------------------- */

            /* ------------------------------ Biến in C# ----------------------------- */
            // string name = "Hoang Anh";
            // char inital = 'A';
            // int age = 22;
            // float money = 3.99F;
            // double money1 = 3.99D;
            // bool myBool = true;
            // Console.WriteLine("name: " + name);
            // Console.WriteLine("inital: " + inital);
            // Console.WriteLine("age: " +age);
            // Console.WriteLine("money: " + money);
            // Console.WriteLine("money1: " + money1);
            // Console.WriteLine("myBool: " +myBool);
            /* ---------------------------------------------------------------------- */

            /* ------------------------------ Bài tập nhỏ -------------------------- */
            //VD: x=5; y=6; z=10; => x+y+z
            // int x=5,y=6,z=10;
            // int m = x+y+z;
            // String s = Convert.ToString(m);
            // Type mType = m.GetType();
            // string kQ = "Ket Qua: ";
            // Console.WriteLine(kQ + (m));
            // Console.WriteLine(Convert.ToString(m));  chyển thành string
            // Console.WriteLine(mType);
            /* -------------------------------------------------------------------- */

            /* ------------------------------ PP Chuyển đổi kiểu ---------------- */
            // int myInt = 10;
            // Console.WriteLine(Convert.ToString(myInt));
            // Console.WriteLine(Convert.ToInt32(myInt));
            // Console.WriteLine(Convert.ToDouble(myInt));
            /* ----------------------------------------------------------------- */

            /* -------------------------- Lấy dữ liệu của người dùng nhập vào --------- */
            Console.WriteLine("Name");
            string myString = Console.ReadLine();
            Console.WriteLine("My name is:" +myString);
            Console.WriteLine("Age");
            int myInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age is: " + myInt);
            /* ----------------------------------------------------------------------- */
        }
    }
}