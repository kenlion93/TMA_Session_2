using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(sumAtoB(4,10));
            Console.WriteLine(LieykeNT(2,13));
            /*
             Hello();
            Hi("Jason");
            Tong(5, 5);
            double r = avg(4, 5, 6);
            Console.WriteLine("Diem trung binh = " + r);
             */
            Console.ReadLine();
        }
        /*
         * 1. Xay dung function co user and pwd. user = abc vaf pwd = 123 => true, nguoi lai false
         * 2. Xay dung function co 2 so nguye a,b. Tinh tong cac so tu a->b
         * 3. Kiem tra so nguyen to. Co uoc cua no = 2
         * 4. Liet ke cac so nguyen to trong khoang a->b
         */
        static bool Nguyento(int n)
        {
            int count = 0;
            for(int i = 1; i<=n; i++)
            {
                if (n%i == 0)
                {
                    count++;
                }
            }

            return count == 2;
        }

        static void LieykeNT(int a, int b)
        {
            for (int i = a; i<= b; i++)
            {
                if(Nguyento(i))
                {
                    Console.Write(" " + i);
                }
            }
        }
        static int sumAtoB(int a, int b)
        {
            int s= 0;
            for (int i = a; i<= b; i++)
            {
                s+=i;
            }
            return s;
        }
        static bool login(string user, string pwd)
        {
            // return user == "abc" && pwd == "123";
            if (user == "abc" && pwd == "123")
            {
                return true;
            }                
                return false;
        }
        static double avg(double toan, double ly, double hoa)
        {
            double result_1 = (toan * 3 + ly * 2 + hoa) / 6;
            return result_1;
        }
        //void la ko co ket qua tra ve
        static void Tong(int a,int b)
        {
            int result = a+b;
            Console.WriteLine("Tong "+a+ " va "+b+ " = "+ result);
        }
        static void Hi (string fullname)
        {
            Console.WriteLine("Hi "+fullname);
        }
        static void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
}
