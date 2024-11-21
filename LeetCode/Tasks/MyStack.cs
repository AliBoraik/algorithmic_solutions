namespace LeetCode.Tasks;

public class MyStack
{
    /*
     Implement a last-in-first-out (LIFO) stack using only two queues. The implemented stack should support all the 
     functions of a normal stack (push, top, pop, and empty).
       
       Implement the MyStack class:
       
       void push(int x) Pushes element x to the top of the stack.
       int pop() Removes the element on the top of the stack and returns it.
       int top() Returns the element on the top of the stack.
       boolean empty() Returns true if the stack is empty, false otherwise.
       Notes:
       
       You must use only standard operations of a queue, which means that only push to back, peek/pop from front, size and is empty operations are valid.
       Depending on your language, the queue may not be supported natively. You may simulate a queue using a
       list or deque (double-ended queue) as long as you use only a queue's standard operations.
     */
    private readonly Queue<int> _queue = new();

    public void Push(int x) {
        _queue.Enqueue(x);
        for (int i = 0; i < _queue.Count - 1; i++) {
            _queue.Enqueue(_queue.Dequeue());
        }
    }
    
    public int Pop() {
        return _queue.Dequeue();
    }

    public int Top() {
        return _queue.Peek();
    }

    public bool Empty() {
        return _queue.Count == 0;
    }
}