using PH2_QuanLyMonHocTheoCTDT.Manager;
using PH2_QuanLyMonHocTheoCTDT.Models;
using System;
using System.Collections.Generic;

namespace PH2_QuanLyMonHocTheoCTDT
{
    class Program
    {
        static void Main(string[] args)
        {
            BacDTManager bacDTManager = new BacDTManager();
            bacDTManager.ShowMenu();
        }
    }
}
