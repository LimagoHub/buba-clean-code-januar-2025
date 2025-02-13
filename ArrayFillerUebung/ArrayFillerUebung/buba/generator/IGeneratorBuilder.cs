namespace ArrayFillerUebung.buba.generator;

public interface IGeneratorBuilder<T>
{
    IGenerator<T> create();
}