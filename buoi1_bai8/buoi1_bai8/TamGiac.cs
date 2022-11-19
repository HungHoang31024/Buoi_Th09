using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai8
{
    internal class TamGiac
    {
        private int a;
        private int b;
        private int c;     
        private int i;

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        public TamGiac()
        {
            A = 2;
            B = 3;
            C = -5;
            
        }
        public TamGiac(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
         
        }
        private int chuVi()
        {
            return (A + B + C);

        }

        private double dienTich()
        {
            double p;         
            p = chuVi() / 2;
            Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return p;
        }
       
        private int loaitg()
        {
            if((A == B) || (B == C) || (A == C))
            {
                if(A == B && B == C)
                    return 1;
                else
                {
                    if ((A * A == B * B + C * C) || (B * B == A * A + C * C) || (C * C == A * A + B * B))
                        return 2;
                    else

                        return 3;
                }
            }
            else
            {
                if (A * A == B * B + C * C || B * B == A * A + C * C || C * C == A * A + B * B)
                    return 4;
                else
                    return 5;
            }           
        }
        public void hien()
        {
            Console.WriteLine("______________");
            Console.WriteLine("Hiển Thị thông tin Tam giác");
            Console.WriteLine("---------------");
            Console.WriteLine("Đô dài ba cạnh: {0},{1},{2}", A, B, C);
            Console.WriteLine("Chu vi:{0}" , chuVi());            
            Console.Write("Diện tích:{0}", dienTich()); 
            Console.WriteLine(dienTich() > 0);

            i = loaitg();
            switch (i)
            {
                case 1:
                    Console.WriteLine("là tam giác đều");
                    break;

                case 2:
                    Console.WriteLine("là tam giác vuông cân");
                    break;

                case 3:
                    Console.WriteLine("là tam giác cân");
                    break;

                case 4:
                    Console.WriteLine("là tam giác vuông");
                    break;

                case 5:
                    Console.WriteLine("là tam giác thường");
                    break;
            }
        }
    }
}
