class StepCounter
{
    public int Steps { get; private set; }

    public void Step()
    {
        Steps++;
    }
    public void Reset()
    {
        Steps = 0;
    }
}