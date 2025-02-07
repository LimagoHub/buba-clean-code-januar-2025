using ArrayFillerUebung.buba.time;

namespace ArrayFillerUebung.buba.container.inner.decorators;

public class ArrayFactoryBenchmarkDekorator<T>: IArrayFactory<T>
{
    private readonly IArrayFactory<T> _factory;
    private readonly IStopwatch _stopwatch;

    public ArrayFactoryBenchmarkDekorator(IArrayFactory<T> factory, IStopwatch stopwatch)
    {
        _factory = factory;
        _stopwatch = stopwatch;
    }

   
    

    public T[] CreateAndFillArray(int size)
    {
        _stopwatch.Start();
        var result =  _factory.CreateAndFillArray(size);
        _stopwatch.Stop();
        Console.WriteLine($"Duration = {_stopwatch.Elapsed.TotalMilliseconds}");
        return result;
    }
}