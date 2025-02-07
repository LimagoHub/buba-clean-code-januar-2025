using ArrayFillerUebung.buba.container.inner.decorators;
using ArrayFillerUebung.buba.container.inner.sequential;
using ArrayFillerUebung.buba.generator;
using ArrayFillerUebung.buba.time;

namespace ArrayFillerUebung.buba.container;


public class ArrayFactoryBuilder
{
    public static IStopwatch? Benchmark { get; set; }
    public static bool logger { get; set; } = false;
    public static IArrayFactory<int> CreateArrayFactory(IGenerator<int> generator)
    {
        IArrayFactory<int> factory = new ArrayFactorySequentialImpl<int>(generator);

        if (logger) factory = new ArrayFactoryLoggerDecorator<int>(factory);
        
        if (Benchmark!=null) factory = 
            new ArrayFactoryBenchmarkDekorator<int>(factory, Benchmark);
        
        return factory;
    }
}