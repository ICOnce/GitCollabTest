using System;

public class Gaffel
{
	public Gaffel(int numberOfPointies, double albedo)
	{
        _numberOfPointies = numberOfPointies;
        if (albedo > 0.5d) { _isShiny = true; }
	}

    private int _numberOfPointies;
    private bool _isShiny;

    private bool IsShiny { get { return _isShiny; } }
    private int NumberOfPoints {  get { return _numberOfPointies; } }

    #region Arbitrær region
    //dette er en arbitrær region
    #endregion

    public void GoodFork()
    {
        if (_isShiny) Console.WriteLine("yes");
        else Console.WriteLine("no");

    }


}
