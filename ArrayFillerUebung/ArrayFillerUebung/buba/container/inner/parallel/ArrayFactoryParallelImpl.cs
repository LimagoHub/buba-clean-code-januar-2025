using ArrayFillerUebung.buba.generator;

namespace ArrayFillerUebung.buba.container.inner.parallel;

public class ArrayFactoryParallelImpl<T>: AbstractArrayFactory<T>
{
    private readonly IGenerator <T> _generator;
    private readonly int _numberOfThreads;
    private readonly IList<Task> _threadHolder ;
    private int _partitionSize;
    public ArrayFactoryParallelImpl(IGenerator<T> generator, int numberOfThreads)
    {
        _generator = generator;
        _numberOfThreads = numberOfThreads;
        _threadHolder = new List<Task>(_numberOfThreads);
    }

    protected override void FillData()
    {
        CalculatePartitionSize();
        AddWorkerToThreadPool();
        AwaitTermination();
    }
    
    private void CalculatePartitionSize() => _partitionSize = (int)(Data.Length / _numberOfThreads);

    private void AwaitTermination() => Task.WaitAll(_threadHolder.ToArray());

    private void AddWorkerToThreadPool()
    {
        for (int currentThreadNumber = 0; currentThreadNumber < _numberOfThreads; currentThreadNumber++)
        {
            StartSingleWorker(currentThreadNumber);
        }
    }

    private void StartSingleWorker(int currentThreadNumber)
    {
        int start = _partitionSize * currentThreadNumber;
        int end = start + _partitionSize;
        _threadHolder.Add(Task.Run(()=>this.FillPartionWorker(start, end)));
    }

    private void FillPartionWorker(int start, int end)
    {
        //Console.WriteLine($"Start: {start} End: {end}");
        for (int i = start; i < end; i++)
        {
            Data[i] = _generator.Next();
        }
    }
}