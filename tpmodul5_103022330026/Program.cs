using System;

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
        DataGeneric<long> dataNIM = new DataGeneric<long>(103022330026);

        dataNIM.PrintData();
    }
}
