using System;
using static System.Console;

class Program
{
    static void Main()
        {
            Task4();
        }
    static void Task4()
    {
        DLL dll = new DLL();
        int[] a = GenerateUniqueNumbers(10);
        foreach (int i in a)
        {
            dll.AddFirst(i);
            dll.AddLast(i);
        }
        WriteLine("DLL nodes in reverse order");
        PrintBackwards(dll);
        FindMiddle(dll);
    }
    static void PrintBackwards(DLL dll)
    {
        if(dll == null) return; 
        DLLNode? t = dll; 
        while(t != null){ 
            Write(t.Num + " ");
            t = t.Next; 
        }
        WriteLine();
    }
    static int GetDLLSize(DLLNode dll)
    {
        if(dll == null) return 0;
        DLLNode? t = dll;
        int count = 0;
        while(t != null){
            count++;
            t = t.Next;
        }
        return count;
    }
    static void FindMiddle(DLL? dll)
    {
        if(dll == null) return;
        DLLNode? t = dll; 
        int i = 0; 
        int middle_idx = (GetDLLSize(dll) / 2) - 1;
        while(t != null && i < middle_idx){ 
            t = t.Next;
            i++; 
        }
        if(t != null){
            WriteLine($"Middle node: {t.Num}");
        }
    }
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
    class DLL
    {
    public DLLNode? Head {get;set;}
    public DLLNode? Tail {get;set;}
    public DLL(){
        Head = Tail = null;
    }
    public DLLNode? RemoveLast(){
        if(Tail == null) return null;
        DLLNode t = Tail;
        if(Tail.Prev == null){
            Head = Tail = null;
        }else{
            Tail = Tail.Prev;
            Tail.Next = null;
            t.Prev = null;
        }
        return t;
    }
    public DLLNode? RemoveFirst(){
        if(Head == null || Tail == null) return null;
        DLLNode t = Head;
        if(Head.Next == null){
            Head = Tail = null;
        }else{
            Head = Head.Next;
            Head.Prev = null;
            t.Next = null;
        }
        return t;
    }
    public void AddLast(int e){
        var node = new DLLNode(e);
        if(Head == null || Tail == null){
            Head = Tail = node;
        }else{
            Tail.Next = node;
            node.Prev = Tail;
            Tail = node;
        }
    }
    public void AddFirst(int e)
    {
        var node = new DLLNode(e);
        if(Head == null || Tail == null){
            Head = Tail = node;
        }else{
            node.Next = Head;
            Head.Prev = node;
            Head = node;
        }
    }
    }
    class DLLNode
    {
        public int Num {get;set;}
        public DLLNode? Prev{get;set;}
        public DLLNode? Next {get;set;}
        public DLLNode(int elem){this.Num = elem;
    }
}