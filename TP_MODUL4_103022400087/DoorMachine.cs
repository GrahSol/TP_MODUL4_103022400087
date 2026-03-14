using System;

public class DoorMachine
{
    enum State { Terkunci, Terbuka };
    private State currentState = State.Terkunci;

    public void HandleCommand(string command)
    {
        switch (currentState)
        {
            case State.Terkunci:
                if (command == "BukaPintu")
                {
                    currentState = State.Terbuka;
                    Console.WriteLine("Pintu tidak terkunci");
                }
                break;

            case State.Terbuka:
                if (command == "KunciPintu")
                {
                    currentState = State.Terkunci;
                    Console.WriteLine("Pintu terkunci");
                }
                break;
        }
    }
}