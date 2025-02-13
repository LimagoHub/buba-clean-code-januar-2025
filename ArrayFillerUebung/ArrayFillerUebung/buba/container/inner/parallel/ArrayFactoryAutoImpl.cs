using ArrayFillerUebung.buba.generator;
using System.Threading.Tasks;
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
        
        Parallel.For(0, Data.Length, i => { Data[i] = _generator.Next();});
       
    }
}

