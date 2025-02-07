using ArrayFillerUebung.buba.generator;

namespace ArrayFillerUebung.buba.container.inner.sequential;

public class ArrayFactorySequentialImpl<T>: AbstractArrayFactory<T>
{
    private readonly IGenerator<T> _generator;

    public ArrayFactorySequentialImpl(IGenerator<T> generator)
    {
        this._generator = generator;
    }

    protected override void FillData()
    {
        for (var i = 0; i < Data.Length; i++)
        {
            Data[i] = _generator.Next();
        }
    }
}