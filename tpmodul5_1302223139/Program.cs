using System;
class program
{
    public class HaloGeneric
    {
        public void SapaUser<X>(X nama)
        {
            Console.WriteLine("Halo user " + nama);
        }
    }

    public class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T inputData)
        {
            data = inputData;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }

    public static void Main(string[] args)
    {
        HaloGeneric HG1 = new HaloGeneric();

        Console.WriteLine("Masukkan nama panggilan Anda:");
        string namaPanggilan = Console.ReadLine();
        HG1.SapaUser(namaPanggilan);

        DataGeneric<string> DG1 = new DataGeneric<string>("1302223139");
        DG1.PrintData();
    }
}