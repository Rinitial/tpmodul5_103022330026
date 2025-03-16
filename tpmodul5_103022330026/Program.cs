using System;

class HaloGeneric
{
    public void SapaUser(string input)
    {
        Console.WriteLine("Halo user " + input);
    }
}

class DataGeneric<T>
{
    public T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}

class Program
{
    static void Main()
    {
        // Menjalankan fitur HaloGeneric
        Console.Write("Masukkan nama: ");
        string input = Console.ReadLine();
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(input);

        // Menjalankan fitur DataGeneric dengan NIM
        DataGeneric<long> dataNIM = new DataGeneric<long>(103022330026);
        dataNIM.PrintData();
    }
}
