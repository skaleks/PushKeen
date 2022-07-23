using System.Collections.Generic;

public class PauseHandler : IPauseable
{
    private List<IPauseable> _pauseables = new List<IPauseable>();
    public bool IsPaused { get; private set; }



    public void Add(IPauseable pauseable)
    {
        _pauseables.Add(pauseable);
    }

    public void Remove(IPauseable pauseable)
    {
        _pauseables.Remove(pauseable);
    }


    public void SetPaused(bool isPaused)
    {
        IsPaused = isPaused;

        foreach (IPauseable pauseable in _pauseables)
        {
            pauseable.SetPaused(isPaused);
        }
    }
}
