using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai9
{
    internal class PhuongTrinhBacHai
    {
        private int _soa;
        private int _sob;
        private int _soc;

        public int a { get => _soa; set => _soa = value; }
        public int b { get => _sob; set => _sob = value; }
        public int c { get => _soc; set => _soc = value; }

        public PhuongTrinhBacHai()
        {
            a = 0; 
            b = 0; 
            c = 0;
        }
        public PhuongTrinhBacHai(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
       
        
        public void tinhnghiem()
        {
            float x, y;          
            float delta = b * b - 4 * a * c;
            if (delta > 0) 
            {
                x = (float)(-b - Math.Sqrt(delta)) / 2 * a;
                y = (float)(-b + Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("PT co hai nghiem phan biet:");
                Console.WriteLine("x = {0}; y = {1}", x, y);
                
            }
            else if (delta == 0)
             {
                    x = -b / 2 * a;
                    Console.WriteLine("nghiem kep x = y ={0}", x);
             }
            else
            {

                Console.WriteLine("khong co nghiem");
            }
        }
        public void nhap()
         {
            Console.Write("\t -Nhap diem a:");
            int temp;
            temp = int.Parse(Console.ReadLine());
            a = temp;
            Console.Write("\t -Nhap diem b: ");
            temp = int.Parse(Console.ReadLine());
            b = temp;
            Console.Write("\t -Nhap diem c:");
            temp = int.Parse(Console.ReadLine());
            c = temp;
        }
        public void hien()
        {                
          Console.WriteLine("\na: {0,-15}, b: {1,-15},C:{2,-15}", a, b, c);

        }
        
    }
}
