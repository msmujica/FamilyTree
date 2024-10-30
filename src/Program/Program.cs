using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Parte 2
            Node<Person> Abuela = new Node<Person>(new Person("Abuela María", 90));
            Node<Person> Abuelo = new Node<Person>(new Person("Abuelo José", 85));
            Node<Person> Mama = new Node<Person>(new Person("Mamá Ana", 61));
            Node<Person> Papa = new Node<Person>(new Person("Papá CarlosTercero", 55));
            Node<Person> Hijo = new Node<Person>(new Person("Hijo Lucas", 20));
            Node<Person> Hija = new Node<Person>(new Person("Hija Sofía", 18));
            Node<Person> Tia = new Node<Person>(new Person("Tía Laura", 45));

            Abuela.AddChildren(Papa);
            Abuela.AddChildren(Tia);
            
            Abuelo.AddChildren(Mama);

            Mama.AddChildren(Hijo);
            Mama.AddChildren(Hija);

            Papa.AddChildren(Hijo);
            Papa.AddChildren(Hija);

            //Parte 3
            SumVisitor visitorA = new SumVisitor(); 
            Abuela.Accept(visitorA);

            Console.WriteLine("La suma de las edades es: " + visitorA.Sum);
            
            //Parte 4
            MaxAgeVisitor maxAgeVisitor = new MaxAgeVisitor();
            Abuela.Accept(maxAgeVisitor);
            Console.WriteLine("La edad del hijo más grande es: " + maxAgeVisitor.MaxAge);

            LongerNameVisitor longerName = new LongerNameVisitor();
            Abuela.Accept(longerName);
            Console.WriteLine("El nombre mas largo del arbol genelogico es:" + longerName.LongestName);
        }
    }
}
