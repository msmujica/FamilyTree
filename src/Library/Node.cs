namespace Library;

using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Node<T>
{
    private T generico;

    private List<Node<T>> children = new List<Node<T>>();

    public T Generico {
        get
        {
            return this.generico;
        }
        set
        {
            generico = value;
        }
    }

    public ReadOnlyCollection<Node<T>> Children {
        get
        {
            return this.children.AsReadOnly();
        }
    }

    public Node(T generico)
    {
        this.Generico = generico;
    }

    public void AddChildren(Node<T> n)
    {
        this.children.Add(n);
    }
    public void Accept(IVisitor<T> visitor)
    {
        visitor.Visit(this);
        foreach (var item in this.children)
        {
            item.Accept(visitor);
        }
    }

    public int IntermedioEdad(Node<Person> person)
    {
        return person.Generico.Edad;
    }
}
