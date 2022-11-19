using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            PhuongTrinhBacHai x = new PhuongTrinhBacHai();
            x.nhap();
            x.hien();
            x.tinhnghiem();
            PhuongTrinhBacHai y = new PhuongTrinhBacHai();
            
            y.hien();
            y.tinhnghiem();
            
            Console.ReadKey();
           

        }
    }
}
