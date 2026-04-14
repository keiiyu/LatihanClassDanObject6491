using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassAndObject6491
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            saya.Nim = "12345";
            saya.Nama = "Jono";
            saya.Ipk = 3.95f;

            kamu.Nim = "12346";
            kamu.Nama = "Paijo";
            kamu.Ipk = 3.70f;

            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
