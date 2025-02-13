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
    public static IArrayFactory<int> CreateArrayFactory(IGeneratorBuilder<int> generatorBuilder)
    {
        IArrayFactory<int> factory;
        switch (numberOfThreads)
        {
            case 0: 
                factory = new ArrayFactoryAutoImpl<int>(generatorBuilder.create());
                break;
            case 1 :
                factory = new ArrayFactorySequentialImpl<int>(generatorBuilder.create());
                break;
            default:
                factory = new ArrayFactoryParallelImpl<int>(generatorBuilder, numberOfThreads);
                break;
        }

       
        if (logger) factory = new ArrayFactoryLoggerDecorator<int>(factory);
        
        if (Benchmark!=null) factory = 
            new ArrayFactoryBenchmarkDekorator<int>(factory, Benchmark);
        
        return factory;
    }
}