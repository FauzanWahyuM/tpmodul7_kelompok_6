using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace tpmodul7_kelompok_6
{
    class Program
    {
        public class Nama
        {
            public string Depan { get; set; }
            public string Belakang { get; set; }
        }

        public class DataMahasiswa
        {
            public Nama Nama { get; set; }
            public long NIM { get; set; }
            public string Fakultas { get; set; }
        }

        public static void ReadJSON()
        {
            string filePath = "tp7_1_2211104027.json";

            if (File.Exists(filePath))
            {
                try
                {
                    string jsonData = File.ReadAllText(filePath);

                    DataMahasiswa mahasiswa = JsonConvert.DeserializeObject<DataMahasiswa>(jsonData);

                    Console.WriteLine($"Nama {mahasiswa.Nama.Depan} {mahasiswa.Nama.Belakang} dengan nim {mahasiswa.NIM} dari fakultas {mahasiswa.Fakultas}");
                }
                catch (JsonReaderException ex)
                {
                    Console.WriteLine("Terjadi kesalahan saat membaca JSON: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("File JSON tidak ditemukan!");
            }
        }

        static void Main()
        {
            ReadJSON();
        }
    }
}
