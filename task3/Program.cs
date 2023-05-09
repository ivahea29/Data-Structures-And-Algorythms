using static System.Console;
class Program
{
    static void Main()
    {
        Task3();
    }

    static void Task3()
    {
        SLL sll = new SLL();
        int[] a = GenerateUniqueNumbers(10);
        foreach(int i in a)
        {
            sll.AddFirst(i);
        }
        WriteLine("SLL nodes");
        PrintSLL(sll.Head);
        WriteLine($"SLL length: {GetSLLSize(sll.Head)}");
        FindSLLMiddle(sll.Head);
    }

    static void PrintSLL(SLLNode? node)
    {
        if(node == null) return; 
        SLLNode? t = node; 
        while(t != null){ 
            Write(t.Num + " ");
            t = t.Next; 
        }
        WriteLine();
    }

    static int GetSLLSize(SLLNode? node)
    {
        if(node == null) return 0;
        SLLNode? t = node;
        int count = 0;
        while(t != null){
            count++;
            t = t.Next;
        }
        return count;
    }

    static void FindSLLMiddle(SLLNode node)
    {
        if(node == null) return;
        SLLNode? t = node; 
        int i = 0; 
        int middle_idx = (GetSLLSize(node) / 2) - 1;
        while(t != null && i < middle_idx){ 
            t = t.Next;
            i++; 
        }
        if(t != null){
            WriteLine($"Middle node: {t.Num}");
        }
    }
    /* Pseudo code
        if the node is null stop process.
        define the middle number using the total size of the list and divide by 2 minus one so it is the index of that number
        traverse the list until the middle index is reached.
        add value of middle index to predefined variable
        print variable.
    */
    static int[] GenerateUniqueNumbers(int size)
    {
        Random random = new Random();
        var values = new HashSet<int>();
        while (true)
        {
            values.Add(random.Next(1, 100));
            if (values.Count == size) break;
        }
        return values.ToArray();
    }
}

class SLL
{
    public SLLNode? Head {get; set;} 
    public SLLNode? Tail {get; set;}
    public SLL()
    {
        Head = Tail = null;
    }
    public void AddFirst(int e)
    {
        SLLNode node = new SLLNode(e);
        if(Head == null) 
        {
            Head = Tail = node;
        }else{
            node.Next = Head;
            Head = node;
        }
    }
}

class SLLNode
{
    public int Num{get; set;}
    public SLLNode? Next{get; set;}
    public SLLNode(int elem)
    {
        this.Num = elem;
    }

}
