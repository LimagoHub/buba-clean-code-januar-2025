using ArrayFillerUebung.buba.generator;

namespace ArrayFillerUebung.buba.container.inner.parallel;

public class ArrayFactoryParallelImpl<T>: AbstractArrayFactory<T>
{
    public ArrayFactoryParallelImpl(IGenerator<T> generator, int numberOfThreads)
    {
    }

    protected override void FillData()
    {
        throw new NotImplementedException();
    }
}