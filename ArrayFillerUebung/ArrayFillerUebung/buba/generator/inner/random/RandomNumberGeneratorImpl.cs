namespace ArrayFillerUebung.buba.generator;

public class RandomNumberGeneratorImpl: IGenerator<int>
{
    private readonly Random _random = new Random(unchecked(Environment.TickCount + Thread.CurrentThread.ManagedThreadId));
    public virtual int Next()
    {
        return _random.Next();
    }
}