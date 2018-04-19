using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Bang Cuu Chuong------------");
            for (int i = 1; i<= 5; i++)
            {
                Console.WriteLine("Bang cuu chuong: " + i);
                for(int j = 1; j <= 5; j++)
                {
                    Console.Write("\t"+i+"x"+j+"="+(i*j));
                }
                Console.WriteLine();
            }

            /*
            for (int r = 1; r <= 3; r++)
            {
                Console.WriteLine("Row: " + r);
                for(int c = 1; c <= 5; c++)
                {
                    Console.Write(" " + c);
                }
                Console.WriteLine();
            }
            */

            /*
            for (int i = 1; i <= 10; i++ )
            {
                if (i %2 == 0)
                {
                    Console.Write(" " + i);
                    break;
                }
            }
            Console.WriteLine("\nDone");
            */
                /*int m,n;
                do{
                  Console.WriteLine("Moi nhap so m: ");
                  m = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Moi nhap so n: ");
                  n = Convert.ToInt32(Console.ReadLine());
                  if(m>n)
                  {
                      Console.WriteLine("Moi ban nhap lai. M phai nho hon N");
                  }
                  }while(m>n);
                Console.WriteLine("M = "+m+"\nN = "+n);
                 */
                //------------------------Do - While------------------------------------------------
                /*Nhap 2 so nguyen m va n. Neu m > n thi nhap lai */



                /*double math;
                do{
                    Console.Write("Math: ");
                    math = Convert.ToDouble(Console.ReadLine());
                    if (math < 0 || math > 10)
                    {
                        Console.WriteLine("Invalid");
                    }
                }while(math < 0 || math > 10);
                Console.WriteLine("Result: " + math);
                */
                /* int i = 11;
                while (i <= 10)
                {
                    Console.Write(" " + i);
                    i++;
                }

                Console.WriteLine("\nDo-While\n");

                int j = 11;
                do
                {
                    Console.Write(" " + j);
                    j++;
                } while (j <= 10);
                */
                //------------------------FOR------------------------------------------------
                /*
                 * Nhap 2 so m va n. Hien thi menu
                 * 1. Liet ke cac so chan tu m de n
                 * 2. Liet ke cac so le tu m de n
                 * 3. Dem bao nhiu so chan
                 * 4. Tinh tong cac so chan
                 */
                /*
                string key;
                do{
                    Console.Clear();
                    Console.WriteLine("Moi nhap so m: ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Moi nhap so n: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("---------------");
                    Console.WriteLine("1. Liet ke cac so chan");
                    Console.WriteLine("2. Liet ke cac so le");
                    Console.WriteLine("3. Dem co bao nhieu so chan");
                    Console.WriteLine("4. Tinh tong cac so chan");
                    Console.WriteLine("Moi ban chon: ");
                    int menu =Convert.ToInt32(Console.ReadLine());
            
                    switch(menu)
                    {
                        case 1:
                            Console.Write("Cac so chan: ");
                            for(int i = m; i<=n; i++)
                            {
                                if(i%2 == 0)
                                {
                                Console.Write(" " + i);
                        
                                }
                            }
                            break;
                        case 2:
                              for(int i = m; i<=n; i++)
                                {
                                    if(i%2 != 0)
                                    {
                                    Console.WriteLine("Cac so le: " + i);
                                    }
                                }
                            break;
                        case 3:
                            int count = 0;
                            for(int i = m; i<=n; i++)
                            {
                                if(i%2 == 0)
                                {
                                count++;                        
                                }
                            }
                            Console.WriteLine("Ta co " + count + " so chan");
                            break;
                        case 4:
                            int sum = 0;
                            for (int i = m; i <= n; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    //sum = sum+i
                                    sum += i;
                                }
                            }
                            Console.WriteLine("Tong so chan la: " + sum);
                            break;

                        default:
                            Console.WriteLine("Tuy chon khong hop le");
                            break;
                    }
                    Console.WriteLine("\nNhan Y(y) de tiep tuc");
                    key = Console.ReadLine();
                }
                while(key== "Y" || key == "y");
                 */
                /* for (int i = 1; i <= 10;i++ )
                {
                    if (i%2 == 0)
                    {
                        Console.WriteLine("Hellow World " + i);
                    }
                
                }*/



                Console.ReadLine();
        }
    }
}
