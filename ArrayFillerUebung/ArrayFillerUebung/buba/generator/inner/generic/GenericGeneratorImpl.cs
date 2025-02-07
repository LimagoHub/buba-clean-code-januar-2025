namespace ArrayFillerUebung.buba.generator.inner;

public class GenericGeneratorImpl: IIntGenerator
{

    private int _value;
    private readonly Func<int, int> _func;
    public GenericGeneratorImpl(int seed, Func<int, int> fkt)
    {
        this._value = seed;
        this._func = fkt;
    }
    
    public int Next()
    {
        var result = _value;
        _value = _func(_value);
        return result;
    }
}