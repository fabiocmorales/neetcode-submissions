public class MinStack
{
    private LinkedList<int> _stack;
    private LinkedList<int> _stackMin;

    public MinStack()
    {
        _stack = new LinkedList<int>();
        _stackMin = new LinkedList<int>();
    }

    public void Push(int val)
    {
        _stack.AddLast(val);
        _stackMin.AddLast(_stackMin.Count == 0 ? val : Math.Min(val, _stackMin.Last.Value));
    }

    public void Pop()
    {
        _stack.RemoveLast();
        _stackMin.RemoveLast();
    }

    public int Top()
    {
        return _stack.Last.Value;
    }

    public int GetMin()
    {
        return _stackMin.Last.Value;
    }
}