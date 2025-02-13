using ArrayFillerUebung.buba.client;
using ArrayFillerUebung.buba.container;
using ArrayFillerUebung.buba.container.inner.sequential;
using ArrayFillerUebung.buba.generator;
using ArrayFillerUebung.buba.generator.inner;
using ArrayFillerUebung.buba.time;

namespace ArrayFillerUebung.buba.bootstrap;

public class Bootstrap
{
    public void StartApplication()
    {
        var availableProcessors = Environment.ProcessorCount;
        for (var threadCount = 0; threadCount <= availableProcessors +1; threadCount++)
        {
            Run(threadCount);
        }
        
    }

    private void Run(int threadCount)
    {
        Console.WriteLine($"Running with {threadCount} threads.");
        IGeneratorBuilder<int> generatorBuilder = new RandomGeneratorBuilderImpl();
        //IGenerator<int> generator = new GenericGeneratorImpl(1, v=>v+2);
        ArrayFactoryBuilder.logger = true;
        ArrayFactoryBuilder.Benchmark= new StopwatchImpl();
        ArrayFactoryBuilder.numberOfThreads = threadCount;
        IArrayFactory<int> factory = ArrayFactoryBuilder.CreateArrayFactory(generatorBuilder);
        IClient client = new ClientImpl(factory);
        client.DoSomethingWithLargeArray();

    }
    
    
}