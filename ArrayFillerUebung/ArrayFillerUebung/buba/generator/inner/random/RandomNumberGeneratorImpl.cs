namespace ArrayFillerUebung.buba.generator;

public class RandomNumberGeneratorImpl: IIntGenerator
{
    //private readonly Random _random = new Random();
    public virtual int Next()
    {
        return Random.Shared.Next();
    }
}