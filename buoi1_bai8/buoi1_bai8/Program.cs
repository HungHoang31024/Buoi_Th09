using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TamGiac tg = new TamGiac();

           Console.WriteLine("Canh1 cua tam giac: " + tg.A);
           Console.WriteLine("Canh2 cua tam giac: " + tg.B);
           Console.WriteLine("Canh3 cua tam giac: " + tg.C);
            

            tg.hien();
            Console.ReadLine();
        }
    }
}
