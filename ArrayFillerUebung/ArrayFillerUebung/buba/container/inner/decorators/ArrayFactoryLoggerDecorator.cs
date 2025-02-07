namespace ArrayFillerUebung.buba.container.inner.decorators;

public class ArrayFactoryLoggerDecorator<T>: IArrayFactory<T>
{
    private readonly IArrayFactory<T> _factory;

    public ArrayFactoryLoggerDecorator(IArrayFactory<T> factory)
    {
        _factory = factory;
    }

    public T[] CreateAndFillArray(int size)
    {
        Console.WriteLine($"CreateAndFillArray wurde mit Size {size}  aufgerufen");
        return _factory.CreateAndFillArray(size);
    }
}