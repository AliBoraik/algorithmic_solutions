namespace LeetCode.Tasks;

public class MyQueue
{
    /*
        Implement a first in first out (FIFO) queue using only two stacks.
         The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).

       Implement the MyQueue class:

       void push(int x) Pushes element x to the back of the queue.
       int pop() Removes the element from the front of the queue and returns it.
       int peek() Returns the element at the front of the queue.
       boolean empty() Returns true if the queue is empty, false otherwise.
       Notes:

       You must use only standard operations of a stack, which means only push to top, peek/pop from top,
        size, and is empty operations are valid.
       Depending on your language, the stack may not be supported natively. You may simulate a stack using a
       list or deque (double-ended queue) as long as you use only a stack's standard operations.
     */

    private readonly Stack<int> _inputStack = new();
    private readonly Stack<int> _outputStack = new();
    
    public MyQueue() { }

    public void Push(int x)
    {
        // Move elements from outputStack to inputStack
        while (_outputStack.Count > 0)
        {
            _inputStack.Push(_outputStack.Pop());
        }

        // Push the new element onto inputStack
        _inputStack.Push(x);

        // Move elements from inputStack to outputStack
        while (_inputStack.Count > 0)
        {
            _outputStack.Push(_inputStack.Pop());
        }
    }

    public int Pop()
    {
        return _outputStack.Pop();
    }

    public int Peek()
    {
        return _outputStack.Peek();
    }

    public bool Empty()
    {
        return _outputStack.Count == 0;
    }
}