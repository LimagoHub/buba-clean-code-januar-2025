using ArrayFillerUebung.buba.generator;

namespace ArrayFillerUebung.buba.container.inner.parallel;

public class ArrayFactoryParallelImpl<T>: AbstractArrayFactory<T>
{
    private readonly IGeneratorBuilder <T> _generatorBuilder;
    private readonly int _numberOfThreads;
    private readonly IList<Task> _threadHolder ;
    private int _partitionSize;
    public ArrayFactoryParallelImpl(IGeneratorBuilder<T> generatorBuilder, int numberOfThreads)
    {
        _generatorBuilder = generatorBuilder;
        _numberOfThreads = numberOfThreads;
        _threadHolder = new List<Task>(_numberOfThreads);
    }

    protected override void FillData()
    {
        CalculatePartitionSize();
        AddWorkerToThreadPool();
        AwaitTermination();
    }
    
    private void CalculatePartitionSize() => _partitionSize = (Data.Length / _numberOfThreads);
    private void AddWorkerToThreadPool()
    {
        for (int currentThreadNumber = 0; currentThreadNumber < _numberOfThreads; currentThreadNumber++)
        {
            StartSingleWorker(currentThreadNumber);
        }
    }
    private void AwaitTermination() => Task.WaitAll(_threadHolder.ToArray());
  

    private void StartSingleWorker(int currentThreadNumber)
    {
        int start = _partitionSize * currentThreadNumber;
        int end = start + _partitionSize;
        _threadHolder.Add(Task.Run(()=>this.FillPartionWorker(start, end)));
    }

    private void FillPartionWorker(int start, int end)
    {
        //Console.WriteLine($"Start: {start} End: {end}");

        var generator = _generatorBuilder.create();
        for (int i = start; i < end; i++)
        {
            Data[i] = generator.Next();
        }
    }
}