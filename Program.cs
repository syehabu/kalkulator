using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalklator by Nalendra Harva M";
            Console.WriteLine("Pilihlah Kalkulator : ");
            Console.WriteLine();

            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine();
            Console.Write("Input nomor menu [1-4] : ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (input > 4 || input < 1)
            {
                Console.WriteLine("Maaf , menu tidak tersedia");
                pesan();
            }
            else
            {
                Console.Write("Input nilai a : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("input nilai b : ");
                int b = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Hasil penjumlahan {0} + {1} = {2}", a, b, penjumlahan(a, b));
                }
                else if (input == 2)
                {
                    Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                }
                else if (input == 3)
                {
                    Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
                }
                else if (input == 4)
                {
                    Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
                }
                pesan();
            }
        }

        static int penjumlahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
        static void pesan()
        {
            Console.WriteLine();
            Console.Write("Tekan apa saja untuk keluar ....");
            Console.ReadKey();
        }
    }
}