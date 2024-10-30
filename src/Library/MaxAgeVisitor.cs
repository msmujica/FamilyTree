namespace Library;

public class MaxAgeVisitor : IVisitor<Person>
{
    private int maxAge = 0;
    
    public int MaxAge
    {
        get
        {
            return this.maxAge;
        }
    }

    public void Visit(Node<Person> node)
    {
        if (node.Generico.Edad > maxAge)
        {
            maxAge = node.Generico.Edad;
        }
    }
}