using System.Security.Claims;
using ArrayFillerUebung.buba.container;

namespace ArrayFillerUebung.buba.client;

public class ClientImpl: IClient
{
    private IArrayFactory<int> Factory { get; }

    public ClientImpl(IArrayFactory<int> factory)
    {
        Factory = factory;
    }

    public void DoSomethingWithLargeArray()
    {
        var feld = Factory.CreateAndFillArray(int.MaxValue / 32);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(feld[i]);
        }
    }
}