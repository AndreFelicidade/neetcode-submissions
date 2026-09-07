public class MinStack {
    private int[] stack = new int[30000];
    private int[] minValStack = new int[30000];
    private int top = -1;

    public MinStack() 
    { 
        
    }
    
    public void Push(int val) 
    {
        top++;
        stack[top] = val;
        
        if (top == 0) 
        {
            minValStack[top] = val;
        } else 
        {
            minValStack[top] = Math.Min(val, minValStack[top - 1]);
        }
    }
    
    public void Pop() {
        if (top >= 0) 
        {
            top--;
        }
    }
    
    public int Top() 
    {
        return stack[top];
    }
    
    public int GetMin() 
    {
        return minValStack[top];
    }
}