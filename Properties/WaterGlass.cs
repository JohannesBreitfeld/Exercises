using System.Security.AccessControl;

class WaterGlass
{
    private bool _isFull;
    private bool _isBroken;

    public void FillGlass()
    {
        if (!_isBroken)
        {
            if (_isFull)
            {
                Console.WriteLine("The glass is already full!");
            }
            else
            {
                Console.WriteLine("Filling up the glass...");
                _isFull = true;
            }
        }
        else
        {
            Console.WriteLine("The glass is broken so you can't fill it up!");
        }
    }
    public void EmptyGlass()
    {
        if (!_isBroken)
        {
            if (_isFull)
            {
                Console.WriteLine("Emptying the glass...");
                _isFull = false;
            }
            else
            {
                Console.WriteLine("The glass is already empty!");
            }
        }
        else
        {
            Console.WriteLine("The glass is broken and already empty!");
        }
    }
    public void BreakGlass()
    {
        _isBroken = true;
    }
}