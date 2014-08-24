public class ImmutableCounter
{
    private readonly int _count;
    private static int _totalCount;

    public ImmutableCounter()
    {
        _count = 0;
    }

    private ImmutableCounter(int count)
    {
        _count = 0;
    }

    public ImmutableCounter GetNextValue()
    {
        _totalCount += 1;
        return new ImmutableCounter(_count + 1);
    }

    public static ImmutableCounter operator ++(ImmutableCounter input)
    {
        return input.GetNextValue();
    }

    public int Count
    {
        get
        {
            return _count;
        }
    }


}