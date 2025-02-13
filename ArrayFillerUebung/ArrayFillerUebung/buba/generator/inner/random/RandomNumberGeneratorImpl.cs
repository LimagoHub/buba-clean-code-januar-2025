namespace ArrayFillerUebung.buba.generator;

public class RandomNumberGeneratorImpl: IGenerator<int>
{
    private readonly Random _random = Random.Shared;
    public virtual int Next()
    {
        return _random.Next();
        //return Random.Shared.Next();
    }
}