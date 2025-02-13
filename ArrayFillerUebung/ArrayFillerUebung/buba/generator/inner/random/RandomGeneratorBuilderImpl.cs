namespace ArrayFillerUebung.buba.generator;

public class RandomGeneratorBuilderImpl: IGeneratorBuilder<int>
{
    public IGenerator<int> create()
    {
        return new RandomNumberGeneratorImpl();
    }
}