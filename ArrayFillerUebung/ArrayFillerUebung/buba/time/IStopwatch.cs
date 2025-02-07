namespace ArrayFillerUebung.buba.time;

public interface IStopwatch
{
    void Start();
    void Stop();
    TimeSpan Elapsed { get; }
}