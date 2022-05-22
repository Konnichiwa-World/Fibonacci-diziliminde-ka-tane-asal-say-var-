using System;
using System.Collections;

class program
{
    public static void Main(string[] args)
    { a1:  System.Console.WriteLine("Lütfen sayi giriniz:");
        Int32 sayi =Int32.Parse(Console.ReadLine());

            ArrayList fibo = new ArrayList(); fibo.Add(1); fibo.Add(1);
            for(int a=0;a<sayi-2;a++){
                fibo.Add(Convert.ToInt32(fibo[a+1])+Convert.ToInt32(fibo[a]));}
            System.Console.WriteLine(" ");
        
            int sayac;
            for (int i = 2; i < sayi; i++)
            {
                sayac = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac == 0)
                {
                    if(fibo.Contains(i)==true){
                        System.Console.WriteLine(i);
                    }
                }
            }
            goto a1;}
}
