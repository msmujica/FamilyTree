namespace Library;

public class Person
{
    private string name;
    private int edad;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }

    public Person(string name, int edad)
    {
        this.Name = name;
        this.Edad = edad;
    }
}