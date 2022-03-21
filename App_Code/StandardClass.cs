/* The class Node<T> **/
public class Node<T>
{
    private T value;           // Node value
    private Node<T> next;      // next Node

    /* Constructor  - returns a Node with "value" as value and without successesor Node **/
    public Node(T value)
    {
        this.value = value;
        this.next = null;
    }

    /* Constructor  - returns a Node with "value" as value and its successesor is "next" **/
    public Node(T value, Node<T> next)
    {
        this.value = value;
        this.next = next;
    }

    /* Returns the Node "value" **/
    public T GetValue()
    {
        return this.value;
    }

    /* Returns the Node "next" Node **/
    public Node<T> GetNext()
    {
        return this.next;
    }

    /* Return if the current Node Has successor **/
    public bool HasNext()
    {
        return (this.next != null);
    }

    /* Set the value attribute to be "value" **/
    public void SetValue(T value)
    {
        this.value = value;
    }

    /* Set the next attribute to be "next" **/
    public void SetNext(Node<T> next)
    {
        this.next = next;
    }

    /* Returns a string that describes  the Node (and its' successesors **/
    public override string ToString()
    {
        return value + "-->" + next;

    }
}
// מחסנית
public class Stack<T>
{
    public Node<T> head;

    public Stack()
    {
        this.head = null;
    }

    public void Push(T x)
    {
        head = new Node<T>(x, head);
        //Node<T> temp = new Node<T>(x);
        //temp.SetNext(head);
        //head = temp;
    }

    public T Pop()
    {
        T x = head.GetValue();
        head = head.GetNext();
        return x;
    }

    public T Top()
    {
        return head.GetValue();
    }

    public bool IsEmpty()
    {
        return head == null;
    }

    public override string ToString()
    {
        if (!IsEmpty())
        {
            string temp = head.ToString();
            return "top -> " + temp.Substring(0, temp.Length - 3) + " bottom";
        }
        return null;
    }

}
// תור
public class Queue<T>
{
    public Node<T> first;
    public Node<T> last;


    public Queue()
    {
        this.first = null;
        this.last = null;
    }

    public void Insert(T x)
    {
        Node<T> temp = new Node<T>(x);
        if (first == null)
            first = temp;
        else
            last.SetNext(temp);
        last = temp;
    }

    public T Remove()
    {
        T x = first.GetValue();
        first = first.GetNext();
        if (first == null)
            last = null;
        return x;
    }

    public T Head()
    {
        return first.GetValue();
    }

    public bool IsEmpty()
    {
        return first == null;
    }

    public override string ToString()
    {
        string temp = first.ToString();
        return "head -> " + temp.Substring(0, temp.Length - 3) + " end";
    }
}


// עץ בינרי 
public class BinNode<T>
{
    private BinNode<T> left;
    private T value;
    private BinNode<T> right;

    public BinNode(T value)
    {
        this.value = value;
        this.left = null;
        this.right = null;
    }

    public BinNode(BinNode<T> left, T value, BinNode<T> right)
    {
        this.left = left;
        this.value = value;
        this.right = right;
    }

    public T GetValue()
    {
        return value;
    }

    public BinNode<T> GetLeft()
    {
        return left;
    }

    public BinNode<T> GetRight()
    {
        return right;
    }

    public bool HasLeft()
    {
        return (left != null);
    }

    public bool HasRight()
    {
        return (right != null);
    }

    public void SetValue(T value)
    {
        this.value = value;
    }

    public void SetLeft(BinNode<T> left)
    {
        this.left = left;
    }

    public void SetRight(BinNode<T> right)
    {
        this.right = right;
    }

    public override string ToString()
    {
        return " ( " + this.left + " " + this.value + " " + this.right + " ) ";
    }

}

