using System;

class Program
{
    static void Main(string[] args)
    {
        KodePos kp = new KodePos();
        Console.WriteLine(kp.getKodePos("Batununggal"));

        DoorMachine door = new DoorMachine();
        door.HandleCommand("BukaPintu");
        door.HandleCommand("KunciPintu");
    }
}