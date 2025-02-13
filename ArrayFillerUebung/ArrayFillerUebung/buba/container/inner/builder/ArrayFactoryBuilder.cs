using ArrayFillerUebung.buba.container.inner.decorators;
using ArrayFillerUebung.buba.container.inner.parallel;
using ArrayFillerUebung.buba.container.inner.sequential;
using ArrayFillerUebung.buba.generator;
using ArrayFillerUebung.buba.time;

namespace ArrayFillerUebung.buba.container;


public class ArrayFactoryBuilder
{
    public static IStopwatch? Benchmark { get; set; }
    public static bool logger { get; set; } = false;
    
    public static int numberOfThreads { get; set; } = 1;
    public static IArrayFactory<int> CreateArrayFactory(IGenerator<int> generator)
    {
        IArrayFactory<int> factory;
        if(numberOfThreads == 1)
            factory = new ArrayFactorySequentialImpl<int>(generator);
        else
        {
            factory = new ArrayFactoryParallelImpl<int>(generator, numberOfThreads);
        }
        if (logger) factory = new ArrayFactoryLoggerDecorator<int>(factory);
        
        if (Benchmark!=null) factory = 
            new ArrayFactoryBenchmarkDekorator<int>(factory, Benchmark);
        
        return factory;
    }
}