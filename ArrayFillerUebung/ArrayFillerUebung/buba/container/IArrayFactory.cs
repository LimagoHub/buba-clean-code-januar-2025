namespace ArrayFillerUebung.buba.container;

public interface IArrayFactory<T>
{
    T[] CreateAndFillArray(int size);
}