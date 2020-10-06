using DemoCodePhanHe.Management;
using System;

namespace DemoCodePhanHe
{
    class Program
    {
        static void Main(string[] args)
        {
            MonHocManager monHocManager = new MonHocManager();
            Console.WriteLine("" + monHocManager.insertMonHoc("PRN292", "FALL", "C#", 1, 2, 3));
            monHocManager.writeData();
        }
    }
}
