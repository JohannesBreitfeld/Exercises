class RedAndBlue
{
    private double _red = 50;
    public double Red
    {
        get
        {
            return double.Parse(string.Format($"{_red: 0.##}"));
        }
        set
        {
            if (value < 0)
            {
                _red = 0;
            }
            else if (value > 100)
            {
                _red = 100;
            }
            else
            {
                _red = value;
            }
            _blue = 100 - _red;
        }
    }
    private double _blue = 50;
    public double Blue
    {
        get
        {
            return double.Parse(string.Format($"{_blue: 0.##}"));
        }
        set
        {
            if (value < 0)
            {
                _blue = 0;
            }
            else if (value > 100)
            {
                _blue = 100;
            }
            else
            {
                _blue = value;
            }
            _red = 100 - _blue;

        }
    }
}