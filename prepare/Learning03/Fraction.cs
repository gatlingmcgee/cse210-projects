using System;

public class Fraction
{
    private int _top;
    private int _bottom;


    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int num)
    {
        _top = num;
        _bottom = 1;
    }
    public Fraction(int numera, int denom)
    {
        _top = numera;
        _bottom = denom;
    }


    public string GetFraction()
    {
        string answer = $"{_top} / {_bottom}";
        return answer;
    }

    public double GetDecimal()
    {
        return (double) _top / (double) _bottom;
    }
}

