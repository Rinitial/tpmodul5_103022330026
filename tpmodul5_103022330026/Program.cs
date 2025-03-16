using System;
class HaloGeneric
{
    public void SapaUser(string input)
    {
        Console.WriteLine("Halo user " + input);
    }
    public static void Main()
    {
        Console.Write("Masukkan nama : ");
        string input = Console.ReadLine();

        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(input);
    }

}
