using static System.Console;

class Program
{
    static void Main()
    {
        Task7();
    }
    static void Task7()
    {
        BST bst = new BST();
        new int[] {3, 2, 5, 1, 7, 9, 6}.ToList().ForEach(i => bst.Insert(i));
        if(bst.Root != null)
        {
            Write("BST in ascending order: ");
            PrintAscending(bst.Root);
            WriteLine(" ");
            Write("BST in descending order: ");
            PrintDescending(bst.Root);
            WriteLine(" ");
            WriteLine($"Count of primes in BST: {CountPrimeNodes(bst.Root)}");
            Write("Prime numbers in BST: ");
            DisplayPrime(bst.Root);
            WriteLine(" ");
            WriteLine($"BST Size: {GetBSTSize(bst.Root)}");
        }
    }
    static void PrintDescending(BSTNode? root)
    {
        if (root == null) return;
        if(root.Right != null) PrintDescending(root.Right);
        Write($"{root.Key, -2}");
        if(root.Left != null) PrintDescending(root.Left);
    }
    static void PrintAscending(BSTNode? root)
    {
        if (root == null) return;
        if(root.Left != null) PrintAscending(root.Left);
        Write($"{root.Key, -2}");
        if(root.Right != null) PrintAscending(root.Right);

    }
    static void DisplayPrime(BSTNode root)
    {
        if(root == null) return;
        if(IsPrime(root.Key).Equals(true)) Write($"{root.Key, -2}");
        if(root.Left != null) DisplayPrime(root.Left);
        if(root.Right != null) DisplayPrime(root.Right);
    } 
    static int CountPrimeNodes(BSTNode? root) 
    {
        if(root == null) return 0;
        int count = IsPrime(root.Key)? 1 : 0;  
        if(root.Left != null) 
        {
            count += CountPrimeNodes(root.Left);
        }
        if(root.Right != null) 
        {
            count += CountPrimeNodes(root.Right);
        }
        return count;
    }    
    static int GetBSTSize(BSTNode? root)
    {
        if (root == null) return 0;
        int count = 1;
        if (root.Left != null)
        {
            count += GetBSTSize(root.Left);
        }
        if (root.Right != null)
        {
            count += GetBSTSize(root.Right);
        }
        return count;
    }
    static bool IsPrime(int n)
    {
        if(n <= 1) return false;
        if(n <= 3) return true;
        for(int i = 2; i <= Math.Sqrt(n); i++)
        {
            if(n % i == 0) return false;
        }
        return true;
    }
}

class BST
{
    public BSTNode? Root {get; set;} 
    public bool Contains(int e)
    {
        BSTNode? t = Root;
        while(t != null)
        {
            if(e == t.Key) return true;
            else if(e < t.Key)
                t = t.Left; 
            else
                t = t.Right;
        }
        return false;
    }
    public bool Insert(int e){  
        BSTNode node = new BSTNode(e); 
        if (Root == null){
            Root = node;
            return true;
        }
        BSTNode t = Root; 
        while(true){ 
            if(e < t.Key){ 
                if(t.Left == null){
                    t.Left = node;
                    return true;
                }
                t = t.Left;
            }else if(e > t.Key){
                if(t.Right == null){ 
                    t.Right = node;
                    return true;
                }
                t = t.Right;
            }else{
                return false;
            }
        }
    }
}
class BSTNode
{
    public int Key {get; set;} 
    public BSTNode? Left {get; set;} 
    public BSTNode? Right {get; set;} 
    public BSTNode(int elem){ 
        this.Key = elem;
    }
}

