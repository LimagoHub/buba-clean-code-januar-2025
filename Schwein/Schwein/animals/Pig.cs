namespace Schwein.animals;

public class Pig
{
    public string Name { get; set; }
    public int Weight
    {
        get => _weight;
        set => _weight = value;
    }
    
    private volatile int _weight;

    public Pig(string name)
    {
        Name = name;
        Weight = 10;
    }

    public void Feed()
    {
        Thread.Sleep(2000);
        Weight++;
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Weight)}: {Weight}";
    }
}