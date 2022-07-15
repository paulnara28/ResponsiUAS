using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<string> daftarMahasiswa = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();


            Console.Write(“Nim = “);
            nim = Convert.ToString(Console.ReadLine());

            Console.Write(“Nama = “);
            nama = Convert.ToString(Console.ReadLine());

            Console.Write(“masukkan jenis kelamin [L / P] = “);
            jeniskelamin = Convert.ToString(Console.ReadLine());
            Console.Write(“ipk = “);
            ipk = Convert.ToDouble(Console.ReadLine());


            if (jeniskelamin == “L” ;
            else if (jeniskelamin == “P”;

            Console.ReadKey();
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            writeln('Input Data Mahasiswa');
            writeln;
            Write('Input Jumlah Data : '); readln(n)

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");

            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            writeln;
            writeln('--------------------------------------------------------------------');
            writeln('| Nim |  Nama Mahasiswa  |    Jenis Kelamin    |   Ipk  | ');
            writeln('--------------------------------------------------------------------');
            for i:= 1 to n do
                    begin
          
             writeln('|    |                  |           |                |             |');
            gotoxy(3, i + 4); writeln(i);
            gotoxy(9, i + 4); writeln(dtmhs[i].nm);
            gotoxy(27, i + 4); writeln(dtmhs[i].nim);
            gotoxy(45, i + 4); writeln(dtmhs[i].Nk);
            gotoxy(61, i + 4); writeln(dtmhs[i].Nh);
            end;
            writeln('--------------------------------------------------------------------');
            readln;
            end;

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
