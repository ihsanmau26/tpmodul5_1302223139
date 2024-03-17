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

    public static void Main(string[] args)
    {
        HaloGeneric HG1 = new HaloGeneric();

        Console.WriteLine("Masukkan nama panggilan Anda:");
        string namaPanggilan = Console.ReadLine();
        HG1.SapaUser(namaPanggilan);
    }
}