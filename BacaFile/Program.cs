using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BacaFile
{

    class Program
    {

        static void Main(string[] args)
        {
            String data;
            try
            {
                //Lewatkan folder dan nama file ke dalam konstruktor StreamReader 
                StreamReader sr = new StreamReader("D:\\Tugas\\SEMESTER 6\\Botcamp Pengembangan Aplikasi\\Project\\Contoh.txt");
                //baca teks baris pertama
                data = sr.ReadLine();
                //lanjutkan sampai akhir file
                while (data != null)
                {
                    //Tuliskan isi 'data' ke dalam console
                    Console.WriteLine(data);
                    //baca baris data berikutnya
                    data = sr.ReadLine();
                }
                //Tutup file nya
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
