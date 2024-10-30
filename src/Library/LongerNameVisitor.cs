namespace Library;

public class LongerNameVisitor : IVisitor<Person>
{
    private string longestName = "";
    
    public string LongestName
    {
        get
        {
            return this.longestName;
        }
    }

    public void Visit(Node<Person> node)
    {
        if (node.Generico.Name.Length > longestName.Length)
        {
            longestName = node.Generico.Name;
        }
    }
}