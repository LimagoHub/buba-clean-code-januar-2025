using ArrayFillerUebung.buba.generator;

namespace ArrayFillerUebung.buba.container.inner.parallel;

public class ArrayFactoryAutoImpl<T>: AbstractArrayFactory<T>
{
    
    private readonly IGenerator<T> _generator;

    public ArrayFactoryAutoImpl(IGenerator<T> generator)
    {
        this._generator = generator;
    }
    protected override void FillData()
    {
        throw new NotImplementedException();
    }
}