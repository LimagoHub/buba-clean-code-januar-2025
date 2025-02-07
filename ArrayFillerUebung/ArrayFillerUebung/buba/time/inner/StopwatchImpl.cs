using System.Diagnostics;

namespace ArrayFillerUebung.buba.time;

public class StopwatchImpl : IStopwatch
{
    private readonly Stopwatch _stopwatch = new Stopwatch();

    public virtual void Start()
    {
        _stopwatch.Start();
    }

    public virtual void Stop()
    {
        _stopwatch.Stop();
    }

    public virtual TimeSpan Elapsed => _stopwatch.Elapsed;
}